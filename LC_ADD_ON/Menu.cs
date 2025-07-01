using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using LC_ADD_ON.Helper;
using LC_ADD_ON.Resources;


namespace LC_ADD_ON
{
    class Menu
    {
        public void BasicStart()
        {
            CompanyConnection(); //1)Company connection 
            //Parent
            CreateMainMenu("43520", "FIL_MN_LC", "Commercial ", 18, 2, false);//parent 2 step
           
            //Sub Menu
            CreateMainMenu("FIL_MN_LC", "SUBMN_MASTER_LC", " Master LC", 0, 2, false);
            CreateMainMenu("FIL_MN_LC", "SUBMN_B2BLC", "Import LC/TT/RTGS LC (Back To Back)", 1, 2, false);
            CreateMainMenu("FIL_MN_LC", "SUBMN_SALESCONTRACT", "Sales Contract", 2, 2, false);
            
            //Child Menu 
            CreateMainMenu("SUBMN_MASTER_LC", "CHLDMN_MASTERLC", "Master LC", 1, 1, false);
            CreateMainMenu("SUBMN_MASTER_LC", "CHLDMN_LC_AMEND", "Master LC Ammendment", 2, 1, false);

            CreateMainMenu("SUBMN_B2BLC", "CHLDMN_B2BLC", "Import LC/TT/RTGS LC(B2B)", 1, 1, false);
            CreateMainMenu("SUBMN_B2BLC", "CHLDMN_B2B_AMEND", "Import LC/TT/RTGS LC Ammendment (B2B)", 2, 1, false);

            CreateMainMenu("SUBMN_SALESCONTRACT", "CHLDMN_SALCON", "Sales Contract", 1, 1, false);
            CreateMainMenu("SUBMN_SALESCONTRACT", "CHLDMN_SALAMD", "Sales Contract Ammendment", 2, 1, false);
            
        }

        public void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {
                if (pVal.BeforeAction && pVal.MenuUID == "CHLDMN_MASTERLC")
                {
                    MasterLC activeForm = new MasterLC();
                    activeForm.Show();
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.Item("FRMMASLC");
                    try
                    {
                        ofrm.Freeze(true);

                        //Status
                        string status = ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTATUS").Specific).Value;
                        if(status == "O")
                        {
                            SAPbouiCOM.EditText ETSTFULL = (SAPbouiCOM.EditText)ofrm.Items.Item("ETSTFULL").Specific;
                            ETSTFULL.Value = "Open";
                        }

                       

                        //Branch Code Combo box
                        string sqlQuerybpl = string.Format("SELECT {0}BPLId{0},{0}BPLName{0} FROM {0}OBPL{0}", '"');
                        SAPbouiCOM.ComboBox CBCMPANY = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMPANY").Specific;   //object defining- Define a combo box
                        Global.GFunc.setComboBoxValue(CBCMPANY, sqlQuerybpl);
                        CBCMPANY.Select("1", SAPbouiCOM.BoSearchKey.psk_ByValue);


                        //Payment type Combo box
                        string sqlQueryptrms = string.Format("SELECT {0}FldValue{0},{0}Descr{0} FROM {0}UFD1{0}  where {0}TableID{0} = '@FIL_OLCB' AND {0}FieldID{0} = 24 ", '"');
                        SAPbouiCOM.ComboBox CBPTRMS1 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS1").Specific;   //object defining- Define a combo box
                        Global.GFunc.setComboBoxValue(CBPTRMS1, sqlQueryptrms);

                        //Days type Combo box
                        string sqlQueryptrms2 = string.Format("SELECT {0}FldValue{0},{0}Descr{0} FROM {0}UFD1{0}  where {0}TableID{0} = '@FIL_OLCB' AND {0}FieldID{0} = 25 ", '"');
                        SAPbouiCOM.ComboBox CBPTRMS2 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS2").Specific;   //object defining- Define a combo box
                        Global.GFunc.setComboBoxValue(CBPTRMS2, sqlQueryptrms2);

                        //auto Document Number
                        string db = "@FIL_OLCM";
                        int num = Global.GFunc.GetCodeGeneration(db);
                        String docnum = num.ToString();
                        SAPbouiCOM.EditText ETDOCNUM = (SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCNUM").Specific;
                        ETDOCNUM.Value = docnum;

                        //auto current date for DocDate
                        SAPbouiCOM.EditText ETDOCDAT = (SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCDAT").Specific;
                        string currentDate = DateTime.Now.ToString("yyyyMMdd");
                        ETDOCDAT.Value = currentDate;

                        ////MAtrix Load
                        //SAPbouiCOM.DBDataSource DBDataSourceLine = (SAPbouiCOM.DBDataSource)ofrm.DataSources.DBDataSources.Item("@FIL_LCM2");
                        //SAPbouiCOM.Matrix MATCUSPO = (SAPbouiCOM.Matrix)ofrm.Items.Item("MATCUSPO").Specific;


                        //if (MATCUSPO.VisualRowCount == 0)
                        //{
                        //    Global.GFunc.SetNewLine(MATCUSPO, DBDataSourceLine, 1, "");// added the line for matrix 1
                        //}ETSTATUS

                        SAPbouiCOM.EditText ETSTATUS = (SAPbouiCOM.EditText)ofrm.Items.Item("ETSTATUS").Specific;
                       

                        ofrm.Freeze(false);

                    }
                    catch(Exception e)
                    {
                        Application.SBO_Application.MessageBox("Error Found : " + e.Message);
                    }
                }
                else if (pVal.BeforeAction && pVal.MenuUID == "CHLDMN_B2BLC")
                {
                    ImportLCB2B activeForm = new ImportLCB2B();
                    activeForm.Show();
                }
                else if (pVal.BeforeAction && pVal.MenuUID == "CHLDMN_SALCON")
                {
                    SalesContract activeForm = new SalesContract();
                    activeForm.Show();
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.Item("FRMSLCON");
                    try
                    {
                        ofrm.Freeze(true);

                        //Branch Code Combo box
                        string sqlQuerybpl = string.Format("SELECT {0}BPLId{0},{0}BPLName{0} FROM {0}OBPL{0}", '"');
                        SAPbouiCOM.ComboBox CBCMPCOD = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMPCOD").Specific;   //object defining- Define a combo box
                        Global.GFunc.setComboBoxValue(CBCMPCOD, sqlQuerybpl);

                        string db = "@FIL_OSCM";
                        int num = Global.GFunc.GetCodeGeneration(db);
                        String docnum = num.ToString();
                        SAPbouiCOM.EditText ETDOCNO = (SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCNO").Specific;
                        ETDOCNO.Value = docnum;

                        SAPbouiCOM.EditText ETDOCDAT = (SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCDAT").Specific;
                        // Set current date in format "yyyyMMdd"
                        string currentDate = DateTime.Now.ToString("yyyyMMdd");
                        ETDOCDAT.Value = currentDate;

                        ofrm.Freeze(false);

                    }
                    catch (Exception e)
                    {
                        Application.SBO_Application.MessageBox("Error Found : " + e.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.ToString(), 1, "Ok", "", "");
            }
        }


        public bool IsFormOpen(string formUID)
        {
            try
            {
                foreach (SAPbouiCOM.Form form in Application.SBO_Application.Forms)
                {
                    if (form.UniqueID == formUID)
                    {
                        return true; // Form is already open (SAPbouiCOM.Form)Application.SBO_Application.Forms
                    }
                }
            }
            catch (Exception ex)
            {
                Global.G_UI_Application.StatusBar.SetText("Error checking form: " + ex.Message,
                   SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            return false; // Form is not open
        }

        private void CompanyConnection()
        {

            try
            {
                string sErrorMsg;
                string cookie;
                string connStr;
                // Global.ocomp.
                Global.oComp = new SAPbobsCOM.Company();
                cookie = Global.oComp.GetContextCookie();
                //    Global.oCompany = new SAPbobsCOM.Company();
                //   cookie =Global.oCompany.GetContextCookie();
                connStr = Application.SBO_Application.Company.GetConnectionContext(cookie);
                Global.oComp.SetSboLoginContext(connStr);
                ////   if (Global.CF.IsSAPHANA())
                ////  {
                ////   Global.oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;
                //// }
                //// else
                //// {
                //Global.ocomp.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2019;
                // }
                // Global.oCompany.Connect();
                Global.G_UI_Application = Application.SBO_Application;
                Global.oComp = (SAPbobsCOM.Company)Application.SBO_Application.Company.GetDICompany(); // Reassign the ocomp with the session we conencted with sap b1
                                                                                                       // sErrorMsg = Global.oCompany.GetLastErrorDescription();
                Application.SBO_Application.StatusBar.SetText("TDS VDS Add-On Connected Successfully", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success);
            }
            catch
            {
                Application.SBO_Application.MessageBox(Global.oComp.GetLastErrorDescription().ToString(), 1, "OK", "", "");
            }
        }

        public void CreateMainMenu(string ParentMenuID, string MenuID, string MenuName, int Position, int imenutype, bool flgimg) // POP UP- PARENT
        {
            try
            {
                SAPbouiCOM.Menus oMenus = null; // Define a variable to "menus"
                SAPbouiCOM.MenuItem oMenuItem = null; // Define a variable to MenuItem

                oMenus = Application.SBO_Application.Menus;  // Assign a SAP menu

                SAPbouiCOM.MenuCreationParams oCreationPackage = null;   //Define a variable to menu creating parameter
                oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));
                oMenuItem = Application.SBO_Application.Menus.Item(ParentMenuID); // "43520" moudles'  //assign a Parent menu




                switch (imenutype)
                {
                    case 2:
                        {
                            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;
                            break;
                        }
                    case 1:
                        {
                            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                            break;
                        }
                    case 3:
                        {
                            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_SEPERATOR;
                            break;
                        }
                }

                oCreationPackage.UniqueID = MenuID;
                oCreationPackage.String = MenuName;
                oCreationPackage.Enabled = true;
                oCreationPackage.Position = Position;  //postion is integer and it start from 0 value

                //string path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath).ToString();
                string path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath).ToString();
                //string Img = string.Concat(path, @"\BANKREC1.png");
                //oCreationPackage.Image = Img;
                if (flgimg == true)
                {


                }
                oMenus = oMenuItem.SubMenus;

                try
                {
                    //  If the menu already exists this code will fail
                    oMenus.AddEx(oCreationPackage);
                }
                catch (Exception ex)
                {

                }
            }
            catch
            {

            }
        }


    }
}
