using LC_ADD_ON.Helper;
using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LC_ADD_ON.Resources
{
    [FormAttribute("LC_ADD_ON.Resources.MasterLC", "Resources/MasterLC.b1f")]
    class MasterLC : UserFormBase
    {
        public MasterLC()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.STCMPANY = ((SAPbouiCOM.StaticText)(this.GetItem("STCMPANY").Specific));
            this.STCUSTMR = ((SAPbouiCOM.StaticText)(this.GetItem("STCUSTMR").Specific));
            this.STSCNO = ((SAPbouiCOM.StaticText)(this.GetItem("STSCNO").Specific));
            this.STLCNO = ((SAPbouiCOM.StaticText)(this.GetItem("STLCNO").Specific));
            this.STDESC = ((SAPbouiCOM.StaticText)(this.GetItem("STDESC").Specific));
            this.STADNTNO = ((SAPbouiCOM.StaticText)(this.GetItem("STADNTNO").Specific));
            this.STISSBNK = ((SAPbouiCOM.StaticText)(this.GetItem("STISSBNK").Specific));
            this.STNEGBNK = ((SAPbouiCOM.StaticText)(this.GetItem("STNEGBNK").Specific));
            this.STVALUE = ((SAPbouiCOM.StaticText)(this.GetItem("STVALUE").Specific));
            this.STSTATUS = ((SAPbouiCOM.StaticText)(this.GetItem("STSTATUS").Specific));
            this.STSCVAL = ((SAPbouiCOM.StaticText)(this.GetItem("STSCVAL").Specific));
            this.STCURR = ((SAPbouiCOM.StaticText)(this.GetItem("STCURR").Specific));
            this.STDOCNUM = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCNUM").Specific));
            this.STDOCDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCDAT").Specific));
            this.STSHIPDT = ((SAPbouiCOM.StaticText)(this.GetItem("STSHIPDT").Specific));
            this.STEXDATE = ((SAPbouiCOM.StaticText)(this.GetItem("STEXDATE").Specific));
            this.STB2BLCP = ((SAPbouiCOM.StaticText)(this.GetItem("STB2BLCP").Specific));
            this.STCONVAL = ((SAPbouiCOM.StaticText)(this.GetItem("STCONVAL").Specific));
            this.STPTRMS1 = ((SAPbouiCOM.StaticText)(this.GetItem("STPTRMS1").Specific));
            this.STPTRMS2 = ((SAPbouiCOM.StaticText)(this.GetItem("STPTRMS2").Specific));
            this.STIOTRMS = ((SAPbouiCOM.StaticText)(this.GetItem("STIOTRMS").Specific));
            this.CBCMPANY = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCMPANY").Specific));
            this.ETCUSTMR = ((SAPbouiCOM.EditText)(this.GetItem("ETCUSTMR").Specific));
            this.ETCUSTMR.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETCUSTMR_ChooseFromListAfter);
            this.ETSTATUS = ((SAPbouiCOM.EditText)(this.GetItem("ETSTATUS").Specific));
            this.ETCDNAME = ((SAPbouiCOM.EditText)(this.GetItem("ETCDNAME").Specific));
            this.ETSCVAL = ((SAPbouiCOM.EditText)(this.GetItem("ETSCVAL").Specific));
            this.ETSCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNO").Specific));
            this.ETSCNO.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETSCNO_ChooseFromListAfter);
            this.ETSCNTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNTRY").Specific));
            this.ETLCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETLCNO").Specific));
            this.ETLCNO.LostFocusAfter += new SAPbouiCOM._IEditTextEvents_LostFocusAfterEventHandler(this.ETLCNO_LostFocusAfter);
            this.ETDESC = ((SAPbouiCOM.EditText)(this.GetItem("ETDESC").Specific));
            this.ETADNTNO = ((SAPbouiCOM.EditText)(this.GetItem("ETADNTNO").Specific));
            this.ETISSBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETISSBNK").Specific));
            this.ETISSBNK.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETISSBNK_ChooseFromListAfter);
            this.ETIBNKNM = ((SAPbouiCOM.EditText)(this.GetItem("ETIBNKNM").Specific));
            this.ETNEGBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETNEGBNK").Specific));
            this.ETNEGBNK.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETNEGBNK_ChooseFromListAfter);
            this.ETNGBNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETNGBNAM").Specific));
            this.ETVALUE = ((SAPbouiCOM.EditText)(this.GetItem("ETVALUE").Specific));
            this.ETCURR = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
            this.ETCURR.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETCURR_ChooseFromListAfter);
            this.ETDOCNUM = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCNUM").Specific));
            this.ETDOCDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCDAT").Specific));
            this.ETSHIPDT = ((SAPbouiCOM.EditText)(this.GetItem("ETSHIPDT").Specific));
            this.ETEXDATE = ((SAPbouiCOM.EditText)(this.GetItem("ETEXDATE").Specific));
            this.ETB2BLCP = ((SAPbouiCOM.EditText)(this.GetItem("ETB2BLCP").Specific));
            this.ETB2BLCP.LostFocusAfter += new SAPbouiCOM._IEditTextEvents_LostFocusAfterEventHandler(this.ETB2BLCP_LostFocusAfter);
            this.ETCONVAL = ((SAPbouiCOM.EditText)(this.GetItem("ETCONVAL").Specific));
            this.CBPTRMS1 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS1").Specific));
            this.CBPTRMS1.ComboSelectAfter += new SAPbouiCOM._IComboBoxEvents_ComboSelectAfterEventHandler(this.CBPTRMS1_ComboSelectAfter);
            this.CBPTRMS2 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS2").Specific));
            this.CBIOTRMS = ((SAPbouiCOM.ComboBox)(this.GetItem("CBIOTRMS").Specific));
            this.FOLCUSPO = ((SAPbouiCOM.Folder)(this.GetItem("FOLCUSPO").Specific));
            this.FOLAMDHS = ((SAPbouiCOM.Folder)(this.GetItem("FOLAMDHS").Specific));
            this.FOLATTAC = ((SAPbouiCOM.Folder)(this.GetItem("FOLATTAC").Specific));
            this.MATCUSPO = ((SAPbouiCOM.Matrix)(this.GetItem("MATCUSPO").Specific));
            this.MATCUSPO.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.MATCUSPO_ChooseFromListAfter);
            this.GRIDADNT = ((SAPbouiCOM.Grid)(this.GetItem("GRIDADNT").Specific));
            this.ETISUDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETISUDAT").Specific));
            this.STISUDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STISUDAT").Specific));
            this.STDCTYPE = ((SAPbouiCOM.StaticText)(this.GetItem("STDCTYPE").Specific));
            this.CBDCTYPE = ((SAPbouiCOM.ComboBox)(this.GetItem("CBDCTYPE").Specific));
            this.CBDCTYPE.ComboSelectAfter += new SAPbouiCOM._IComboBoxEvents_ComboSelectAfterEventHandler(this.CBDCTYPE_ComboSelectAfter);
            this.ADDButton = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.ADDButton.PressedBefore += new SAPbouiCOM._IButtonEvents_PressedBeforeEventHandler(this.ADDButton_PressedBefore);
            this.CancelButton = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.STREMRKS = ((SAPbouiCOM.StaticText)(this.GetItem("STREMRKS").Specific));
            this.ETREMRKS = ((SAPbouiCOM.EditText)(this.GetItem("ETREMRKS").Specific));
            this.ETDOCTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCTRY").Specific));
            this.STRSCAMT = ((SAPbouiCOM.StaticText)(this.GetItem("STRSCAMT").Specific));
            this.ETRSCAMT = ((SAPbouiCOM.EditText)(this.GetItem("ETRSCAMT").Specific));
            this.ETSTFULL = ((SAPbouiCOM.EditText)(this.GetItem("ETSTFULL").Specific));
            this.BRWSBTN = ((SAPbouiCOM.Button)(this.GetItem("BRWSBTN").Specific));
            this.BRWSBTN.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.BRWSBTN_ClickAfter);
            this.DISPBTN = ((SAPbouiCOM.Button)(this.GetItem("DISPBTN").Specific));
            this.DISPBTN.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.DISPBTN_ClickAfter);
            this.DELBTN = ((SAPbouiCOM.Button)(this.GetItem("DELBTN").Specific));
            this.DELBTN.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.DELBTN_ClickAfter);
            this.MATATTAC = ((SAPbouiCOM.Matrix)(this.GetItem("MATATTAC").Specific));
            this.STMMODE = ((SAPbouiCOM.StaticText)(this.GetItem("STMMODE").Specific));
            this.CBMMODE = ((SAPbouiCOM.ComboBox)(this.GetItem("CBMMODE").Specific));
            this.CBMMODE.ComboSelectAfter += new SAPbouiCOM._IComboBoxEvents_ComboSelectAfterEventHandler(this.CBMMODE_ComboSelectAfter);
            this.STCMODE = ((SAPbouiCOM.StaticText)(this.GetItem("STCMODE").Specific));
            this.CBCMODE = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCMODE").Specific));
            this.OnCustomInitialize();

        }
        // In MasterLC.b1f.cs
        public static bool cflflag = false;
        public static double remain = 0.0;

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

       

        private void OnCustomInitialize()
        {

        }
        private SAPbouiCOM.StaticText STCMPANY;
        private SAPbouiCOM.StaticText STCUSTMR;
        private SAPbouiCOM.StaticText STSCNO;
        private SAPbouiCOM.StaticText STLCNO;
        private SAPbouiCOM.StaticText STDESC;
        private SAPbouiCOM.StaticText STADNTNO;
        private SAPbouiCOM.StaticText STISSBNK;
        private SAPbouiCOM.StaticText STNEGBNK;
        private SAPbouiCOM.StaticText STVALUE;
        private SAPbouiCOM.StaticText STSTATUS;
        private SAPbouiCOM.StaticText STSCVAL;
        private SAPbouiCOM.StaticText STCURR;
        private SAPbouiCOM.StaticText STDOCNUM;
        private SAPbouiCOM.StaticText STDOCDAT;
        private SAPbouiCOM.StaticText STSHIPDT;
        private SAPbouiCOM.StaticText STEXDATE;
        private SAPbouiCOM.StaticText STB2BLCP;
        private SAPbouiCOM.StaticText STCONVAL;
        private SAPbouiCOM.StaticText STPTRMS1;
        private SAPbouiCOM.StaticText STPTRMS2;
        private SAPbouiCOM.StaticText STIOTRMS;
        private SAPbouiCOM.StaticText STMMODE;
        private SAPbouiCOM.StaticText STCMODE;
        
        private SAPbouiCOM.ComboBox CBMMODE;
        private SAPbouiCOM.ComboBox CBCMPANY;
        private SAPbouiCOM.ComboBox CBCMODE;

        private SAPbouiCOM.EditText ETCUSTMR;
        private SAPbouiCOM.EditText ETSTATUS;
        private SAPbouiCOM.EditText ETCDNAME;
        private SAPbouiCOM.EditText ETSCVAL;
        private SAPbouiCOM.EditText ETSCNO;
        private SAPbouiCOM.EditText ETSCNTRY;
        private SAPbouiCOM.EditText ETLCNO;
        private SAPbouiCOM.EditText ETDESC;
        private SAPbouiCOM.EditText ETADNTNO;
        private SAPbouiCOM.EditText ETISSBNK;
        private SAPbouiCOM.EditText ETIBNKNM;
        private SAPbouiCOM.EditText ETNEGBNK;
        private SAPbouiCOM.EditText ETNGBNAM;
        private SAPbouiCOM.EditText ETVALUE;
        private SAPbouiCOM.EditText ETCURR;
        private SAPbouiCOM.EditText ETDOCNUM;
        private SAPbouiCOM.EditText ETDOCDAT;
        private SAPbouiCOM.EditText ETSHIPDT;
        private SAPbouiCOM.EditText ETEXDATE;
        private SAPbouiCOM.EditText ETB2BLCP;
        private SAPbouiCOM.EditText ETCONVAL;
        private SAPbouiCOM.ComboBox CBPTRMS1;
        private SAPbouiCOM.ComboBox CBPTRMS2;
        private SAPbouiCOM.ComboBox CBIOTRMS;
        private SAPbouiCOM.Folder FOLCUSPO;
        private SAPbouiCOM.Folder FOLAMDHS;
        private SAPbouiCOM.Folder FOLATTAC;
        private SAPbouiCOM.Matrix MATCUSPO;
        private SAPbouiCOM.Grid GRIDADNT;
        private SAPbouiCOM.EditText ETISUDAT;
        private SAPbouiCOM.StaticText STISUDAT;
        private SAPbouiCOM.StaticText STDCTYPE;
        private SAPbouiCOM.ComboBox CBDCTYPE;
        private SAPbouiCOM.Button ADDButton;
        private SAPbouiCOM.Button CancelButton;
        private SAPbouiCOM.StaticText STREMRKS;
        private SAPbouiCOM.EditText ETREMRKS;
        private SAPbouiCOM.EditText ETDOCTRY;

        private SAPbouiCOM.Matrix MATATTAC;


        private void ETCUSTMR_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg cflArg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;

                SAPbouiCOM.DataTable dt = cflArg.SelectedObjects;
                if (dt == null || dt.Rows.Count == 0)
                    return;

                string CardCode = dt.GetValue("CardCode", 0).ToString();
                string CardName = dt.GetValue("CardName", 0).ToString();


                ETCUSTMR.Value = CardCode;
                ETCDNAME.Value = CardName;

                cflflag = true;

                //MAtrix Load
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);
                SAPbouiCOM.DBDataSource DBDataSourceLine = (SAPbouiCOM.DBDataSource)oForm.DataSources.DBDataSources.Item("@FIL_LCM2");
                SAPbouiCOM.Matrix MATCUSPO = (SAPbouiCOM.Matrix)oForm.Items.Item("MATCUSPO").Specific;


                if (MATCUSPO.VisualRowCount == 0 && cflflag == true)
                {
                    Global.GFunc.SetNewLine(MATCUSPO, DBDataSourceLine, 1, "");// added the line for matrix 1
                }


            }
            catch (Exception e)
            {
                Application.SBO_Application.MessageBox("Error in ChooseFromListAfter: " + e.Message);
            }

        }

        private void ETISSBNK_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg cflArg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;

                SAPbouiCOM.DataTable dt = cflArg.SelectedObjects;
                if (dt == null || dt.Rows.Count == 0)
                    return;

                string BankCode = dt.GetValue("BankCode", 0).ToString();
                string BankName = dt.GetValue("BankName", 0).ToString();



                ETISSBNK.Value = BankCode;
                ETIBNKNM.Value = BankName;



            }
            catch (Exception e)
            {
                Application.SBO_Application.MessageBox("Error in ChooseFromListAfter: " + e.Message);
            }

        }

        private void ETNEGBNK_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg cflArg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;

                SAPbouiCOM.DataTable dt = cflArg.SelectedObjects;
                if (dt == null || dt.Rows.Count == 0)
                    return;

                string BankCode = dt.GetValue("BankCode", 0).ToString();
                string Account = dt.GetValue("Account", 0).ToString();

                ETNEGBNK.Value = BankCode;
                ETNGBNAM.Value = Account;




            }
            catch (Exception e)
            {
                Application.SBO_Application.MessageBox("Error in ChooseFromListAfter: " + e.Message);
            }

        }

        private void ETCURR_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg cflArg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;

                SAPbouiCOM.DataTable dt = cflArg.SelectedObjects;
                if (dt == null || dt.Rows.Count == 0)
                    return;

                string CurrCode = dt.GetValue("CurrCode", 0).ToString();
              

                ETCURR.Value = CurrCode;
               

            }
            catch (Exception e)
            {
                Application.SBO_Application.MessageBox("Error in ChooseFromListAfter: " + e.Message);
            }

        }

        private void ADDButton_PressedBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            SAPbouiCOM.Form oform = Application.SBO_Application.Forms.Item(pVal.FormUID);
            if (oform.Mode == SAPbouiCOM.BoFormMode.fm_ADD_MODE || oform.Mode == SAPbouiCOM.BoFormMode.fm_UPDATE_MODE)
            {
                ValidateForm(ref oform, ref BubbleEvent);
            }

        }

        private bool ValidateForm(ref SAPbouiCOM.Form pForm, ref bool BubbleEvent)
        {
            string CompanyCode = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_BranchCode", 0);
            string Doctype = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_DocType", 0);
            string LCNO = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_LCNo", 0);
            string IssuingBAnk = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_IssueBank", 0);
            string NegBank = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_NegBank", 0);
            string Value = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_Amt", 0);
            string Curr = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_Curr", 0);
            string DocDate = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_DocDate", 0);
            string IssueDate = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_IssueDate", 0);
            string ShipmentDate = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_ShipDate", 0);
            string ExpiryDate = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_ExpDate", 0);
            string LCmode = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("U_MLCTTS", 0);
            string dnum = pForm.DataSources.DBDataSources.Item("@FIL_OLCM").GetValue("DocNum", 0);


            if (CompanyCode == "")
            {
                Global.GFunc.ShowError("Select Company Code");
                pForm.ActiveItem = "CBCMPANY";
                return BubbleEvent = false;
            }
            else if (Doctype == "")
            {
                Global.GFunc.ShowError("Select Document Type");
                pForm.ActiveItem = "CBDCTYPE";
                return BubbleEvent = false;
            }
            else if (LCNO == "")
            {
                Global.GFunc.ShowError("Enter LC Number");
                pForm.ActiveItem = "ETLCNO";
                return BubbleEvent = false;
            }
            else if (LCmode == "")
            {
                Global.GFunc.ShowError("Select LC Mode");
                pForm.ActiveItem = "CBLCMODE";
                return BubbleEvent = false;
            }
            else if (IssuingBAnk == "")
            {
                Global.GFunc.ShowError("Select the Issuing Bank");
                pForm.ActiveItem = "ETISSBNK";
                return BubbleEvent = false;
            }
            else if (NegBank == "")
            {
                Global.GFunc.ShowError("Select The Negotiation Bank ");
                pForm.ActiveItem = "ETNEGBNK";
                return BubbleEvent = false;
            }
            else if (Value == "")
            {
                Global.GFunc.ShowError("Enter the Value");
                pForm.ActiveItem = "ETVALUE";
                return BubbleEvent = false;
            }
            else if (Curr == "")
            {
                Global.GFunc.ShowError("Select the Currency ");
                pForm.ActiveItem = "ETCURR";
                return BubbleEvent = false;
            }
            else if (DocDate == "")
            {
                Global.GFunc.ShowError("Select the Document Date");
                pForm.ActiveItem = "ETDOCDAT";
                return BubbleEvent = false;
            }
            else if (IssueDate == "")
            {
                Global.GFunc.ShowError("Select the Issuing Date");
                pForm.ActiveItem = "ETISUDAT";
                return BubbleEvent = false;
            }
            else if (ShipmentDate == "")
            {
                Global.GFunc.ShowError("Select the Shipment Date");
                pForm.ActiveItem = "ETSHIPDT";
                return BubbleEvent = false;
            }
            else if (ExpiryDate == "")
            {
                Global.GFunc.ShowError("Select the Expiry Date");
                pForm.ActiveItem = "ETEXDATE";
                return BubbleEvent = false;
            }


            // Preventing Empty Row to Add in the DB
            SAPbouiCOM.DBDataSource oDBDetail = pForm.DataSources.DBDataSources.Item("@FIL_LCM2");

            int rowCount = MATCUSPO.VisualRowCount;

            if (rowCount > 0)
            {
                string lastdocentry = oDBDetail.GetValue("U_SODocEntry", rowCount - 1).Trim();
               
               

                if (string.IsNullOrEmpty(lastdocentry))
                {
                    MATCUSPO.DeleteRow(rowCount);
                    oDBDetail.RemoveRecord(rowCount - 1);
                    rowCount--;  // Adjust row count after deletion
                }
            }

            if (pForm.Mode == SAPbouiCOM.BoFormMode.fm_UPDATE_MODE)
            {
                string mode = "";

                // Create Recordset object
                SAPbobsCOM.Recordset oRec = (SAPbobsCOM.Recordset)Global.oComp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                // Assuming dnum is already declared and holds your DocNum (as int or string)
                string sqlQuery = $"SELECT \"U_CLCTTS\" FROM \"@FIL_OLCM\" WHERE \"DocNum\" = {dnum}";

                oRec.DoQuery(sqlQuery);

                if (!oRec.EoF)
                {
                    mode = oRec.Fields.Item("U_CLCTTS").Value.ToString();
                }

                if (mode == "C")
                {
                    Application.SBO_Application.MessageBox("Update not Possible LC is in Confirmed Mode");
                    BubbleEvent = false;
                    return BubbleEvent;
                }
            }

            if (pForm.Mode==SAPbouiCOM.BoFormMode.fm_ADD_MODE)
            {

                //Document number
                int num = Global.GFunc.GetCodeGeneration("@FIL_OLCM");
                ((SAPbouiCOM.EditText)pForm.Items.Item("ETDOCNUM").Specific).Value = num.ToString();
            }



            return BubbleEvent;
        }

        private void ETSCNO_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg cflArg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;

                SAPbouiCOM.DataTable dt = cflArg.SelectedObjects;
                if (dt == null || dt.Rows.Count == 0)
                    return;

                string SCNo = dt.GetValue("U_SCNo", 0).ToString();
                string SCVal = dt.GetValue("U_Amt", 0).ToString();
                string Val = dt.GetValue("U_Amt", 0).ToString();          
                string conamt = dt.GetValue("U_ConAmt", 0).ToString();              
                string ISSBNK = dt.GetValue("U_IssueBank", 0).ToString();
                string ISSBKNM = dt.GetValue("U_IssBName", 0).ToString();
                string NEGBNK = dt.GetValue("U_NegBank", 0).ToString();
                string NEGBKNM = dt.GetValue("U_NegBName", 0).ToString();
                string issudate = dt.GetValue("U_IssueDate", 0).ToString();
                string shipdate = dt.GetValue("U_ShipDate", 0).ToString();
                string expdate = dt.GetValue("U_ExpDate", 0).ToString();
                string SCntry = dt.GetValue("DocEntry", 0).ToString();

                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);
                oForm.Items.Item("ETISSBNK").Enabled = false;
                oForm.Items.Item("ETNEGBNK").Enabled = false;

               

                ETSCNO.Value = SCNo;
                ETSCVAL.Value = SCVal;
                ETVALUE.Value = SCVal;
                ETCONVAL.Value = conamt;
                ETISSBNK.Value = ISSBNK;
                ETIBNKNM.Value = ISSBKNM;
                ETNEGBNK.Value = NEGBNK;
                ETNGBNAM.Value = NEGBKNM;
                ETSCNTRY.Value = SCntry;
                

                // Safely get and format the date values
                DateTime issueDt = Convert.ToDateTime(issudate);
                DateTime shipDt = Convert.ToDateTime(shipdate);
                DateTime expDt = Convert.ToDateTime(expdate);

                // Format as yyyyMMdd or yyyy-MM-dd depending on your requirement
                ETISUDAT.Value = issueDt.ToString("yyyyMMdd");
                ETSHIPDT.Value = shipDt.ToString("yyyyMMdd");
                ETEXDATE.Value = expDt.ToString("yyyyMMdd");


                SAPbobsCOM.Recordset oRS = (SAPbobsCOM.Recordset)Global.oComp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
               
                 string query = string.Format(@"SELECT IFNULL(SUM(""U_Amt""), 0) AS ""TotalAmt"" 
                 FROM ""@FIL_OLCM"" 
                 WHERE ""U_SCNTRY"" = {0}", SCntry);


                oRS.DoQuery(query);

                double totalAmt = 0.0;
                if (!oRS.EoF)
                {
                     totalAmt = Convert.ToDouble(oRS.Fields.Item("TotalAmt").Value);
                    // You can now use totalAmt as needed
                }

                double baseAmt = Convert.ToDouble(SCVal);
                remain = baseAmt - totalAmt;

                string remainAmt = Convert.ToString(remain);

                ETRSCAMT.Value = remainAmt;




                oForm.Items.Item("ETISSBNK").Enabled = true;
                oForm.Items.Item("ETNEGBNK").Enabled = true;


            }
            catch (Exception e)
            {
                Application.SBO_Application.MessageBox("Error in ChooseFromListAfter: " + e.Message);
            }

        }

        private void CBDCTYPE_ComboSelectAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                if (pVal.ItemUID == "CBDCTYPE")
                {
                    SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);
                    SAPbouiCOM.ComboBox oCombo = (SAPbouiCOM.ComboBox)oForm.Items.Item("CBDCTYPE").Specific;

                    string selectedValue = oCombo.Value;

                    if (selectedValue == "LC")
                    {
                        oForm.Freeze(true);

                        oForm.Items.Item("ETSCNO").Enabled = false;
                       

                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETSCNO").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETSCVAL").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETDESC").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETISSBNK").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETIBNKNM").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETNEGBNK").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETNGBNAM").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETVALUE").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETCURR").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETISUDAT").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETSHIPDT").Specific).Value = "";
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETEXDATE").Specific).Value = "";

                        
                        SAPbouiCOM.DBDataSource DBDataSourceLine = (SAPbouiCOM.DBDataSource)oForm.DataSources.DBDataSources.Item("@FIL_LCM2");
                        SAPbouiCOM.Matrix MATCUSPO = (SAPbouiCOM.Matrix)oForm.Items.Item("MATCUSPO").Specific;
                        if (MATCUSPO.VisualRowCount == 0)
                        {
                            Global.GFunc.SetNewLine(MATCUSPO, DBDataSourceLine, 1, "");// added the line for matrix 1
                        }

                        oForm.Freeze(false);
                    }
                    else
                    {
                        oForm.Freeze(true);

                        oForm.Items.Item("ETSCNO").Enabled = true;
                        


                        //SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)oForm.Items.Item("MATCUSPO").Specific;

                        //for (int i = oMatrix.RowCount; i >= 1; i--)
                        //{
                        //    oMatrix.DeleteRow(i);
                        //}

                        oForm.Freeze(false);
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox("Error: " + ex.Message);
            }
        }

        private void MATCUSPO_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            if (pVal.ColUID == "COLSENTY")
            {
                SAPbouiCOM.ISBOChooseFromListEventArg cflArg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                SAPbouiCOM.DataTable dt = cflArg.SelectedObjects;
                SAPbouiCOM.Form oform = Application.SBO_Application.Forms.Item(pVal.FormUID);

                if (dt != null && dt.Rows.Count > 0)
                {
                    string docentry = dt.GetValue("DocEntry", 0).ToString();
                    string docnum = dt.GetValue("DocNum", 0).ToString();
                    string contactno = dt.GetValue("NumAtCard", 0).ToString();

                    SAPbobsCOM.Recordset oRS = (SAPbobsCOM.Recordset)Global.oComp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                    string query = string.Format(@"SELECT SUM(""Quantity"") AS ""TotalQty"", SUM(""OpenSum"") AS ""TotalOpenSum"" FROM ""RDR1"" WHERE ""DocEntry"" = {0}", docentry);
                    oRS.DoQuery(query);

                    string quantity = Convert.ToString(oRS.Fields.Item("TotalQty").Value);
                    string opensum = Convert.ToString(oRS.Fields.Item("TotalOpenSum").Value);

                    SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)this.GetItem("MATCUSPO").Specific;

                    oMatrix.FlushToDataSource();

                    // Set selected values
                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLSENTY").Cells.Item(pVal.Row).Specific).Value = docentry;
                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLSORDR").Cells.Item(pVal.Row).Specific).Value = docnum;
                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLCPONO").Cells.Item(pVal.Row).Specific).Value = contactno;
                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLQTY").Cells.Item(pVal.Row).Specific).Value = quantity;
                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLVALUE").Cells.Item(pVal.Row).Specific).Value = opensum;

                   
                    SAPbouiCOM.Form ofrm = Application.SBO_Application.Forms.Item("FRMMASLC");
                    SAPbouiCOM.DBDataSource DBDataSourceLine = ofrm.DataSources.DBDataSources.Item("@FIL_LCM2");
                    SAPbouiCOM.Matrix MATCUSPO = (SAPbouiCOM.Matrix)ofrm.Items.Item("MATCUSPO").Specific;


                   
                    double totalvalue = 0;

                    for (int i = 1; i <= oMatrix.RowCount; i++)
                    {
                       
                        string val = ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLVALUE").Cells.Item(i).Specific).Value;

                        if (double.TryParse(val, out double qty))
                        {
                            totalvalue += qty;
                        }

                    }

                    if (totalvalue > remain)
                    {
                        Application.SBO_Application.StatusBar.SetText("Amount Exceeds the Remaining Limit", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
                        // Optionally reset the current row’s values
                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLSENTY").Cells.Item(pVal.Row).Specific).Value = "";
                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLSORDR").Cells.Item(pVal.Row).Specific).Value = "";
                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLCPONO").Cells.Item(pVal.Row).Specific).Value = "";
                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLQTY").Cells.Item(pVal.Row).Specific).Value = "";
                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("COLVALUE").Cells.Item(pVal.Row).Specific).Value = "";
                        return;
                    }


                    ((SAPbouiCOM.EditText)oform.Items.Item("ETVALUE").Specific).Value = totalvalue.ToString("0.00");
                  


                    int lastRow = MATCUSPO.RowCount;
                    bool lastRowHasData = !string.IsNullOrEmpty(((SAPbouiCOM.EditText)MATCUSPO.Columns.Item("COLSENTY").Cells.Item(lastRow).Specific).Value);

                    if (pVal.Row == lastRow && lastRowHasData)
                    {

                        Global.GFunc.SetNewLine(MATCUSPO, DBDataSourceLine, 1, "");


                    }
                }
            }
        }

        private void ETB2BLCP_LostFocusAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);

                // Get percentage value
                SAPbouiCOM.EditText etPercent = (SAPbouiCOM.EditText)oForm.Items.Item("ETB2BLCP").Specific;
                string percentText = etPercent.Value.Trim();
                double percentage = 0;
                double.TryParse(percentText, out percentage);

                // Get original value
                SAPbouiCOM.EditText etOriginal = (SAPbouiCOM.EditText)oForm.Items.Item("ETVALUE").Specific;
                string originalText = etOriginal.Value.Trim();
                double originalValue = 0;
                double.TryParse(originalText, out originalValue);

                // Calculate remaining value
                double remainingValue = originalValue - (originalValue * percentage / 100);

                // Set remaining value in ETCONVAL
                SAPbouiCOM.EditText etResult = (SAPbouiCOM.EditText)oForm.Items.Item("ETCONVAL").Specific;
                etResult.Value = remainingValue.ToString("0.00"); // Format to 2 decimals
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox("Error: " + ex.Message);
            }
        }

        private SAPbouiCOM.StaticText STRSCAMT;
        private SAPbouiCOM.EditText ETRSCAMT;

        private void ETLCNO_LostFocusAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);

                // Get the entered LC No
                string lcNo = ((SAPbouiCOM.EditText)oForm.Items.Item("ETLCNO").Specific).Value.Trim();

                if (!string.IsNullOrEmpty(lcNo))
                {
                    // Create recordset
                    SAPbobsCOM.Recordset oRS = (SAPbobsCOM.Recordset)Global.oComp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                    // Just check for existence
                    string query = $@"SELECT 1 FROM ""@FIL_OLCM"" WHERE ""U_LCNo"" = '{lcNo.Replace("'", "''")}'";

                    oRS.DoQuery(query);

                    if (!oRS.EoF)
                    {
                        Application.SBO_Application.StatusBar.SetText("LC No already exists!", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
                        ((SAPbouiCOM.EditText)oForm.Items.Item("ETLCNO").Specific).Value = "";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void CBPTRMS1_ComboSelectAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);

                // Get selected value from CBPTRMS1
                SAPbouiCOM.ComboBox cb1 = (SAPbouiCOM.ComboBox)oForm.Items.Item("CBPTRMS1").Specific;
                string selectedValue = cb1.Selected == null ? "" : cb1.Selected.Value;

                // If selected value is "A", then set CBPTRMS2 to "A"
                if (selectedValue == "A")
                {
                    SAPbouiCOM.ComboBox cb2 = (SAPbouiCOM.ComboBox)oForm.Items.Item("CBPTRMS2").Specific;
                    cb2.Select("H", SAPbouiCOM.BoSearchKey.psk_ByValue);
                }
                if (selectedValue == "V")
                {
                    SAPbouiCOM.ComboBox cb2 = (SAPbouiCOM.ComboBox)oForm.Items.Item("CBPTRMS2").Specific;
                    cb2.Select("O", SAPbouiCOM.BoSearchKey.psk_ByValue);
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private SAPbouiCOM.EditText ETSTFULL;
        private SAPbouiCOM.Button BRWSBTN;
        private SAPbouiCOM.Button DISPBTN;
        private SAPbouiCOM.Button DELBTN;

        private void BRWSBTN_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.Form ofrm = Application.SBO_Application.Forms.Item("FRMMASLC");
            SAPbouiCOM.DBDataSource DBDataSourceLine = ofrm.DataSources.DBDataSources.Item("@FIL_LCM1");
            SAPbouiCOM.Matrix MATATTAC = (SAPbouiCOM.Matrix)ofrm.Items.Item("MATATTAC").Specific;

            // Call file dialog helper
            string filePath = FileDialogHelper.ShowFileDialog();

            if (!string.IsNullOrEmpty(filePath))
            {
                int lastRow = MATATTAC.VisualRowCount;

                // Check if matrix has no rows or the last row's COLATTAC is filled
                bool needNewRow = (lastRow == 0) ||
                                  !string.IsNullOrEmpty(((SAPbouiCOM.EditText)MATATTAC.Columns.Item("COLATTAC").Cells.Item(lastRow).Specific).Value);

                if (needNewRow)
                {
                    // Add new line only if needed
                    Global.GFunc.SetNewLine(MATATTAC, DBDataSourceLine, 1, "");
                    lastRow = MATATTAC.VisualRowCount; // Update to new last row
                }

                // Set the file path in the appropriate row
                ((SAPbouiCOM.EditText)MATATTAC.Columns.Item("COLATTAC").Cells.Item(lastRow).Specific).Value = filePath;
                MATATTAC.FlushToDataSource();
            }
        }



        private void DISPBTN_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.Form ofrm = Application.SBO_Application.Forms.Item("FRMMASLC");
            SAPbouiCOM.Matrix MATATTAC = (SAPbouiCOM.Matrix)ofrm.Items.Item("MATATTAC").Specific;

            for (int i = 1; i <= MATATTAC.RowCount; i++)
            {
                if (MATATTAC.IsRowSelected(i))
                {
                    string filePath = ((SAPbouiCOM.EditText)MATATTAC.Columns.Item("COLATTAC").Cells.Item(i).Specific).Value;

                    if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                    else
                    {
                        Application.SBO_Application.MessageBox("File does not exist or path is empty.");
                    }
                    break;
                }
            }
        }


        private void DELBTN_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.Form ofrm = Application.SBO_Application.Forms.Item("FRMMASLC");
            SAPbouiCOM.Matrix MATATTAC = (SAPbouiCOM.Matrix)ofrm.Items.Item("MATATTAC").Specific;
            SAPbouiCOM.DBDataSource DBDataSourceLine = ofrm.DataSources.DBDataSources.Item("@FIL_LCM1");

            // 💾 Make sure any edits in UI are pushed to DBDataSource first
            MATATTAC.FlushToDataSource();

            for (int i = 1; i <= MATATTAC.RowCount; i++)
            {
                if (MATATTAC.IsRowSelected(i))
                {
                    int rowIndex = i - 1;

                    if (rowIndex >= 0 && rowIndex < DBDataSourceLine.Size)
                    {
                        // ✅ Remove record safely from DBDataSource
                        DBDataSourceLine.RemoveRecord(rowIndex);

                        // 🔁 Reassign LineId to remaining records
                        for (int j = 0; j < DBDataSourceLine.Size; j++)
                        {
                            DBDataSourceLine.Offset = j;
                            DBDataSourceLine.SetValue("LineId", j, (j + 1).ToString());
                        }

                        // ♻️ Reload matrix from the updated data
                        MATATTAC.LoadFromDataSource();
                        Application.SBO_Application.MessageBox("Selected row deleted.");
                    }
                    else
                    {
                        Application.SBO_Application.MessageBox("Invalid row index.");
                    }

                    break; // stop after deleting one selected row
                }
            }
        }

        private void CBMMODE_ComboSelectAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.Form ofrm = Application.SBO_Application.Forms.Item("FRMMASLC");

            // Merchandise Combo
            SAPbouiCOM.ComboBox oComboMerchant = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBMMODE").Specific;
            string selectedValue = oComboMerchant.Value;

            if (selectedValue == "C")
            {
                SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                oItem.Enabled = true;
            }
            else
            {
                SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                oItem.Enabled = false;

                SAPbouiCOM.ComboBox oComboCommercial = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMODE").Specific;
                oComboCommercial.Select("D", SAPbouiCOM.BoSearchKey.psk_ByValue);

            }

        }
    }
}
