﻿using SAPbouiCOM.Framework;
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
                    string formUID = "FRMMASLC"; // Unique ID for the form
                                                           // Check if the form is already open
                    if (IsFormOpen(formUID))
                    {
                        Global.G_UI_Application.Forms.Item(formUID).Select();
                        Global.G_UI_Application.StatusBar.SetText("Form already opened once.",
                            SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                        return;
                    }

                    MasterLC activeForm = new MasterLC();
                    activeForm.Show();
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.Item("FRMMASLC");

                    try
                    {
                        InitializeMasterLCForm(ofrm);
                    }
                    catch (Exception e)
                    {
                        Application.SBO_Application.MessageBox("Error Found : " + e.Message);
                    }



                }
                else if (pVal.BeforeAction && pVal.MenuUID == "CHLDMN_LC_AMEND")
                {
                    string formUID = "FRMLCAMN"; // Unique ID for the form
                                                 // Check if the form is already open
                    if (IsFormOpen(formUID))
                    {
                        Global.G_UI_Application.Forms.Item(formUID).Select();
                        Global.G_UI_Application.StatusBar.SetText("Form already opened once.",
                            SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                        return;
                    }

                    LC_Ammendment activeForm = new LC_Ammendment();
                    activeForm.Show();
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.Item("FRMLCAMN");

                    try
                    {
                        InitializeMLCAmmendmentForm(ofrm);
                    }
                    catch (Exception e)
                    {
                        Application.SBO_Application.MessageBox("Error Found : " + e.Message);
                    }



                }
                else if (pVal.BeforeAction && pVal.MenuUID == "CHLDMN_B2BLC")
                {
                    string formUID = "FRMIMPB2BLC"; // Unique ID for the form
                                                 // Check if the form is already open
                    if (IsFormOpen(formUID))
                    {
                        Global.G_UI_Application.Forms.Item(formUID).Select();
                        Global.G_UI_Application.StatusBar.SetText("Form already opened once.",
                            SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                        return;
                    }
                    ImportLCB2B activeForm = new ImportLCB2B();
                    activeForm.Show();
                }
                else if (pVal.BeforeAction && pVal.MenuUID == "CHLDMN_SALCON")
                {
                    string formUID = "FRMSLCON"; // Unique ID for the form
                                                    // Check if the form is already open
                    if (IsFormOpen(formUID))
                    {
                        Global.G_UI_Application.Forms.Item(formUID).Select();
                        Global.G_UI_Application.StatusBar.SetText("Form already opened once.",
                            SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                        return;
                    }


                    SalesContract activeForm = new SalesContract();
                    activeForm.Show();
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.Item("FRMSLCON");
                    try
                    {
                        InitializeSalesContractForm(ofrm);
                    }
                    catch (Exception e)
                    {
                        Application.SBO_Application.MessageBox("Error Found : " + e.Message);
                    }
                }
                //Add Form Mode Menu
                else if (!pVal.BeforeAction && pVal.MenuUID == "1282")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                InitializeMasterLCForm(ofrm);

                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);
                                break;
                            }
                        case "FRMIMPB2BLC":
                            {
                                
                                break;
                            }
                        case "FRMSLCON":
                            {
                                InitializeSalesContractForm(ofrm);
                                break;
                            }

                    }



                }
                //Find Mode
                else if (!pVal.BeforeAction && pVal.MenuUID == "1281")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                //InitializeMasterLCForm(ofrm);

                                SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                                oItem.Enabled = true;

                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);


                                break;
                            }
                        case "FRMIMPB2BLC":
                            {
                               
                                break;
                            }
                        case "FRMSLCON":
                            {
                                InitializeSalesContractForm(ofrm);
                                break;
                            }

                    }
                }
                //First
                else if (!pVal.BeforeAction && pVal.MenuUID == "1288")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                LoadPrevMasterLCForm(ofrm);
                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);
                                break;
                            }
                        case "FRMIMPB2BLC":
                            {
                                
                                break;
                            }
                        case "FRMSLCON":
                            {
                                InitializeSalesContractForm(ofrm);
                                break;
                            }

                    }
                }
                //Previous
                else if (!pVal.BeforeAction && pVal.MenuUID == "1289")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                LoadPrevMasterLCForm(ofrm);
                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);
                                break;
                            }
                        case "FRMIMPB2BLC":
                            {
                                
                                break;
                            }
                        case "FRMSLCON":
                            {
                                InitializeSalesContractForm(ofrm);
                                break;
                            }

                    }
                }
                //Next
                else if (!pVal.BeforeAction && pVal.MenuUID == "1290")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                LoadPrevMasterLCForm(ofrm);
                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);
                                break;
                            }
                        case "FRMIMPB2BLC":
                            {
                               
                                break;
                            }
                        case "FRMSLCON":
                            {
                                InitializeSalesContractForm(ofrm);
                                break;
                            }

                    }
                }
                //Last
                else if (!pVal.BeforeAction && pVal.MenuUID == "1291")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                LoadPrevMasterLCForm(ofrm);
                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);
                                break;
                            }
                        case "FRMIMPB2BLC":
                            {
                               

                                break;
                            }
                        case "FRMSLCON":
                            {

                                break;
                            }

                    }
                }
                else if (!pVal.BeforeAction && pVal.MenuUID == "1287")
                {
                    SAPbouiCOM.Form ofrm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                    string formtype = ofrm.UniqueID.ToString();
                    switch (formtype)
                    {
                        case "FRMMASLC":
                            {
                                //InitializeMasterLCForm(ofrm);
                                break;
                            }
                        case "FRMLCAMN":
                            {
                                InitializeMLCAmmendmentForm(ofrm);
                               
                                // Get the DocEntry from EditText (string to int)
                                int docentry = int.Parse(((SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCTRY").Specific).Value);

                                // Initialize DI API recordset
                                SAPbobsCOM.Recordset oRec = (SAPbobsCOM.Recordset)Global.oComp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                                // SQL Query to fetch U_LCAMDNO
                                string query = $@"SELECT ""U_LCAMDNO"" FROM ""@FIL_OLCM"" WHERE ""DocEntry"" = {docentry}";

                                // Execute the query
                                oRec.DoQuery(query);

                                // Variable to hold numeric part of U_LCAMDNO
                                int nextNumber = 1;

                                if (!oRec.EoF && !string.IsNullOrEmpty(oRec.Fields.Item("U_LCAMDNO").Value.ToString()))
                                {
                                    // Parse the existing U_LCAMDNO value (e.g., "1", "2")
                                    int currentVal;
                                    if (int.TryParse(oRec.Fields.Item("U_LCAMDNO").Value.ToString(), out currentVal))
                                    {
                                        nextNumber = currentVal + 1;
                                    }
                                }

                                // Set incremented value in ETLCNO EditText
                                ((SAPbouiCOM.EditText)ofrm.Items.Item("ETADNTNO").Specific).Value = nextNumber.ToString();

                                
                                SAPbouiCOM.DBDataSource DBDataSourceLine = ofrm.DataSources.DBDataSources.Item("@FIL_LCM2");
                                SAPbouiCOM.Matrix MATCUSPO = (SAPbouiCOM.Matrix)ofrm.Items.Item("MATCUSPO").Specific;
                                Global.GFunc.SetNewLine(MATCUSPO, DBDataSourceLine, 1, "");

                                break;
                            }
                        case "FRMIMPB2BLC":
                            {

                                break;
                            }
                        case "FRMSLCON":
                            {
                                InitializeSalesContractForm(ofrm);
                                break;
                            }

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

        private void InitializeMasterLCForm(SAPbouiCOM.Form ofrm)
        {
            try
            {
                ofrm.Freeze(true);

                // Status
                string status = ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTATUS").Specific).Value;
                if (status == "O")
                {
                    ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTFULL").Specific).Value = "Open";
                }

                //Default amendment no
                SAPbouiCOM.EditText ETADNTNO = (SAPbouiCOM.EditText)ofrm.Items.Item("ETADNTNO").Specific;
                ETADNTNO.Value = "0";

                //Commercial Status
                SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                oItem.Enabled = false;
                
                SAPbouiCOM.ComboBox oCombo = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMODE").Specific;
                oCombo.Select("D", SAPbouiCOM.BoSearchKey.psk_ByValue);

                // Branch combo
                string sqlQuerybpl = @"SELECT ""BPLId"", ""BPLName"" FROM ""OBPL""";
                SAPbouiCOM.ComboBox CBCMPANY = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMPANY").Specific;
                Global.GFunc.setComboBoxValue(CBCMPANY, sqlQuerybpl);
                CBCMPANY.Select("1", SAPbouiCOM.BoSearchKey.psk_ByValue);

                // Payment terms
                string sqlQueryptrms = @"SELECT ""FldValue"", ""Descr"" FROM ""UFD1"" WHERE ""TableID"" = '@FIL_OLCB' AND ""FieldID"" = 24";
                SAPbouiCOM.ComboBox CBPTRMS1 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS1").Specific;
                Global.GFunc.setComboBoxValue(CBPTRMS1, sqlQueryptrms);

                // Days terms
                string sqlQueryptrms2 = @"SELECT ""FldValue"", ""Descr"" FROM ""UFD1"" WHERE ""TableID"" = '@FIL_OLCB' AND ""FieldID"" = 25";
                SAPbouiCOM.ComboBox CBPTRMS2 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS2").Specific;
                Global.GFunc.setComboBoxValue(CBPTRMS2, sqlQueryptrms2);

                // Document number
                int num = Global.GFunc.GetCodeGeneration("@FIL_OLCM");
                ((SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCNUM").Specific).Value = num.ToString();

                // Document date
                ((SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCDAT").Specific).Value = DateTime.Now.ToString("yyyyMMdd");

                

            }
            finally
            {
                ofrm.Freeze(false);
            }
        }

        private void LoadPrevMasterLCForm(SAPbouiCOM.Form ofrm)
        {
            try
            {
                ofrm.Freeze(true);

                // Status
                string status = ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTATUS").Specific).Value;
                if (status == "O")
                {
                    ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTFULL").Specific).Value = "Open";
                }

                // Merchandise Combo //Commercial Status
                SAPbouiCOM.ComboBox oComboMerchant = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBMMODE").Specific;
                string selectedValue = oComboMerchant.Value;

                if (selectedValue == "D") 
                { 
                    
                    SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                    oItem.Enabled = false;
                }
                else if(selectedValue =="C")
                {
                    SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                    oItem.Enabled = true;
                }

                

                // Branch combo
                string sqlQuerybpl = @"SELECT ""BPLId"", ""BPLName"" FROM ""OBPL""";
                SAPbouiCOM.ComboBox CBCMPANY = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMPANY").Specific;
                Global.GFunc.setComboBoxValue(CBCMPANY, sqlQuerybpl);
                

                // Payment terms
                string sqlQueryptrms = @"SELECT ""FldValue"", ""Descr"" FROM ""UFD1"" WHERE ""TableID"" = '@FIL_OLCB' AND ""FieldID"" = 24";
                SAPbouiCOM.ComboBox CBPTRMS1 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS1").Specific;
                Global.GFunc.setComboBoxValue(CBPTRMS1, sqlQueryptrms);

                // Days terms
                string sqlQueryptrms2 = @"SELECT ""FldValue"", ""Descr"" FROM ""UFD1"" WHERE ""TableID"" = '@FIL_OLCB' AND ""FieldID"" = 25";
                SAPbouiCOM.ComboBox CBPTRMS2 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS2").Specific;
                Global.GFunc.setComboBoxValue(CBPTRMS2, sqlQueryptrms2);

                



            }
            finally
            {
                ofrm.Freeze(false);
            }
        }
        private void InitializeMLCAmmendmentForm(SAPbouiCOM.Form ofrm)
        {
            try
            {
                ofrm.Freeze(true);

                // Status

                string stat = ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTAT").Specific).Value;
                if (stat == "O")
                {
                    ((SAPbouiCOM.EditText)ofrm.Items.Item("ETSTNAM").Specific).Value = "Open";
                }

                // Merchandise Combo
               
                

                // Branch combo
                string sqlQuerybpl = @"SELECT ""BPLId"", ""BPLName"" FROM ""OBPL""";
                SAPbouiCOM.ComboBox CBCMPANY = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBCMPANY").Specific;
                Global.GFunc.setComboBoxValue(CBCMPANY, sqlQuerybpl);
                

                // Payment terms
                string sqlQueryptrms = @"SELECT ""FldValue"", ""Descr"" FROM ""UFD1"" WHERE ""TableID"" = '@FIL_OLCB' AND ""FieldID"" = 24";
                SAPbouiCOM.ComboBox CBPTRMS1 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS1").Specific;
                Global.GFunc.setComboBoxValue(CBPTRMS1, sqlQueryptrms);

                // Days terms
                string sqlQueryptrms2 = @"SELECT ""FldValue"", ""Descr"" FROM ""UFD1"" WHERE ""TableID"" = '@FIL_OLCB' AND ""FieldID"" = 25";
                SAPbouiCOM.ComboBox CBPTRMS2 = (SAPbouiCOM.ComboBox)ofrm.Items.Item("CBPTRMS2").Specific;
                Global.GFunc.setComboBoxValue(CBPTRMS2, sqlQueryptrms2);


                if (ofrm.Mode == SAPbouiCOM.BoFormMode.fm_ADD_MODE )
                {
                    SAPbouiCOM.Item oItem = ofrm.Items.Item("CBCMODE");
                    oItem.Enabled = false;

                    // Document number
                    int num = Global.GFunc.GetCodeGeneration("@FIL_OLCM");
                    ((SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCNO").Specific).Value = num.ToString();

                    // Document date
                    ((SAPbouiCOM.EditText)ofrm.Items.Item("ETDOCDAT").Specific).Value = DateTime.Now.ToString("yyyyMMdd");
                }

            }
            finally
            {
                ofrm.Freeze(false);
            }
        }

        private void InitializeSalesContractForm(SAPbouiCOM.Form ofrm)
        {
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

                
            }
            finally
            {
                ofrm.Freeze(false);
            }
        }



    }
}
