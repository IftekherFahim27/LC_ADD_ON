using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbouiCOM.Framework;
using LC_ADD_ON.Helper;
using LC_ADD_ON.Resources;


namespace LC_ADD_ON.Modules
{
    class StandardFormHandling
    {
        public StandardFormHandling()
        {
            Application.SBO_Application.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler(SBO_Application_ItemEvent);
        }

        private void SBO_Application_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            if ( pVal.FormTypeEx == "9999" && pVal.ItemUID == "1" && pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED )
            {
                try
                {
                    // Make sure FRMSBGRP is open
                    SAPbouiCOM.Form ofrm;
                    try
                    {
                        ofrm = Application.SBO_Application.Forms.Item("FRMLCAMN");
                    }
                    catch
                    {
                        Application.SBO_Application.StatusBar.SetText("FRMLCAMN form is not open.", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
                        return;
                    }

                    if (ofrm.Mode == SAPbouiCOM.BoFormMode.fm_OK_MODE || ofrm.Mode == SAPbouiCOM.BoFormMode.fm_FIND_MODE)
                    {
                        
                        ofrm.Freeze(true);

                        

                        // Get selected value from CBSERISE
                        string selectedValue ="";
                        if (string.IsNullOrEmpty(selectedValue))
                        {
                            // ── Get value from Form 9999 Matrix ──
                            SAPbouiCOM.Form frm9999 = Application.SBO_Application.Forms.Item(pVal.FormUID);
                            SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)frm9999.Items.Item("7").Specific;

                            int rowSelected = oMatrix.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder);

                            if (rowSelected > 0)
                            {
                                selectedValue = ((SAPbouiCOM.EditText)oMatrix.Columns.Item("U_LCNo").Cells.Item(rowSelected).Specific).Value;
                            }
                        }
                        string sqlQuery = $@"
    SELECT 
        ""LogInst"",
        ""CreateDate"",
        ""U_CardCode"" AS ""CardCode"",
        ""U_LCNo"" AS ""LCNo"",
        ""U_SCNo"" AS ""SCNo"",
        ""U_Desc"" AS ""Desc"",
        ""U_DocDate"" AS ""DocDate"",
        ""U_IssueDate"" AS ""IssueDate"",
        ""U_ShipDate"" AS ""ShipDate"",
        ""U_ExpDate"" AS ""ExpDate"",
        ""U_Amt"" AS ""Amount"",
        ""U_Curr"" AS ""Currency"",
        ""U_IssueBank"" AS ""IssuBank"",
        ""U_NegBank"" AS ""NegoBank"",
        ""U_PTerm1"" AS ""Payment"",
        ""U_PTerm2"" AS ""Days"",
        ""U_INCOTRMS"" AS ""Inco Terms""
    FROM ""@FIL_OLCM""
    WHERE ""U_LCNo"" = '{selectedValue}';
";
                        // Execute Query and Load into DataTable
                        SAPbouiCOM.DataTable dt = ofrm.DataSources.DataTables.Item("DTAMDMENT");
                        dt.ExecuteQuery(sqlQuery);

                        // Bind the Grid
                        SAPbouiCOM.Grid grid = (SAPbouiCOM.Grid)ofrm.Items.Item("GDAMDHIS").Specific;
                        grid.DataTable = dt;

                        Application.SBO_Application.StatusBar.SetText("Amendment History Loaded.", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success);



                        ofrm.Freeze(false);
                    }
                }
                catch (Exception ex)
                {
                    Application.SBO_Application.StatusBar.SetText("Error after button press: " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
                }
            }


        }

    }
}
