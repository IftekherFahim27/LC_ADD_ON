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
            this.STJOBNO = ((SAPbouiCOM.StaticText)(this.GetItem("STJOBNO").Specific));
            this.STVALUE = ((SAPbouiCOM.StaticText)(this.GetItem("STVALUE").Specific));
            this.STFNCOMP = ((SAPbouiCOM.StaticText)(this.GetItem("STFNCOMP").Specific));
            this.STLOCOMP = ((SAPbouiCOM.StaticText)(this.GetItem("STLOCOMP").Specific));
            this.STNETFOB = ((SAPbouiCOM.StaticText)(this.GetItem("STNETFOB").Specific));
            this.STSTATUS = ((SAPbouiCOM.StaticText)(this.GetItem("STSTATUS").Specific));
            this.STSCVAL = ((SAPbouiCOM.StaticText)(this.GetItem("STSCVAL").Specific));
            this.STCURR = ((SAPbouiCOM.StaticText)(this.GetItem("STCURR").Specific));
            this.STFRGCOM = ((SAPbouiCOM.StaticText)(this.GetItem("STFRGCOM").Specific));
            this.STLOCOMM = ((SAPbouiCOM.StaticText)(this.GetItem("STLOCOMM").Specific));
            this.STDOCNUM = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCNUM").Specific));
            this.STDOCDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCDAT").Specific));
            this.STSHIPDT = ((SAPbouiCOM.StaticText)(this.GetItem("STSHIPDT").Specific));
            this.STEXDATE = ((SAPbouiCOM.StaticText)(this.GetItem("STEXDATE").Specific));
            this.STQTY = ((SAPbouiCOM.StaticText)(this.GetItem("STQTY").Specific));
            this.STB2BLCP = ((SAPbouiCOM.StaticText)(this.GetItem("STB2BLCP").Specific));
            this.STCONVAL = ((SAPbouiCOM.StaticText)(this.GetItem("STCONVAL").Specific));
            this.STPTRMS1 = ((SAPbouiCOM.StaticText)(this.GetItem("STPTRMS1").Specific));
            this.STPTRMS2 = ((SAPbouiCOM.StaticText)(this.GetItem("STPTRMS2").Specific));
            this.STIOTRMS = ((SAPbouiCOM.StaticText)(this.GetItem("STIOTRMS").Specific));
            this.STAPRATC = ((SAPbouiCOM.StaticText)(this.GetItem("STAPRATC").Specific));
            this.CBCMPANY = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCMPANY").Specific));
            this.ETCUSTMR = ((SAPbouiCOM.EditText)(this.GetItem("ETCUSTMR").Specific));
            this.ETCUSTMR.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETCUSTMR_ChooseFromListAfter);
            this.ETSTATUS = ((SAPbouiCOM.EditText)(this.GetItem("ETSTATUS").Specific));
            this.ETCDNAME = ((SAPbouiCOM.EditText)(this.GetItem("ETCDNAME").Specific));
            this.ETSCVAL = ((SAPbouiCOM.EditText)(this.GetItem("ETSCVAL").Specific));
            this.ETSCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNO").Specific));
            this.ETSCNTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNTRY").Specific));
            this.ETLCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETLCNO").Specific));
            this.ETDESC = ((SAPbouiCOM.EditText)(this.GetItem("ETDESC").Specific));
            this.ETADNTNO = ((SAPbouiCOM.EditText)(this.GetItem("ETADNTNO").Specific));
            this.ETISSBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETISSBNK").Specific));
            this.ETISSBNK.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETISSBNK_ChooseFromListAfter);
            this.ETIBNKNM = ((SAPbouiCOM.EditText)(this.GetItem("ETIBNKNM").Specific));
            this.ETNEGBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETNEGBNK").Specific));
            this.ETNEGBNK.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETNEGBNK_ChooseFromListAfter);
            this.ETNGBNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETNGBNAM").Specific));
            this.ETJOBNO = ((SAPbouiCOM.EditText)(this.GetItem("ETJOBNO").Specific));
            this.ETJOBNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETJOBNAM").Specific));
            this.ETVALUE = ((SAPbouiCOM.EditText)(this.GetItem("ETVALUE").Specific));
            this.ETFNCOMP = ((SAPbouiCOM.EditText)(this.GetItem("ETFNCOMP").Specific));
            this.ETLOCOMP = ((SAPbouiCOM.EditText)(this.GetItem("ETLOCOMP").Specific));
            this.ETNETFOB = ((SAPbouiCOM.EditText)(this.GetItem("ETNETFOB").Specific));
            this.ETCURR = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
            this.ETCURR.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETCURR_ChooseFromListAfter);
            this.ETFRGCOM = ((SAPbouiCOM.EditText)(this.GetItem("ETFRGCOM").Specific));
            this.ETLOCOMM = ((SAPbouiCOM.EditText)(this.GetItem("ETLOCOMM").Specific));
            this.ETDOCNUM = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCNUM").Specific));
            this.ETDOCDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCDAT").Specific));
            this.ETSHIPDT = ((SAPbouiCOM.EditText)(this.GetItem("ETSHIPDT").Specific));
            this.ETEXDATE = ((SAPbouiCOM.EditText)(this.GetItem("ETEXDATE").Specific));
            this.ETQTY = ((SAPbouiCOM.EditText)(this.GetItem("ETQTY").Specific));
            this.ETB2BLCP = ((SAPbouiCOM.EditText)(this.GetItem("ETB2BLCP").Specific));
            this.ETCONVAL = ((SAPbouiCOM.EditText)(this.GetItem("ETCONVAL").Specific));
            this.CBPTRMS1 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS1").Specific));
            this.CBPTRMS2 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS2").Specific));
            this.CBIOTRMS = ((SAPbouiCOM.ComboBox)(this.GetItem("CBIOTRMS").Specific));
            this.ETAPRATC = ((SAPbouiCOM.EditText)(this.GetItem("ETAPRATC").Specific));
            this.FOLCUSPO = ((SAPbouiCOM.Folder)(this.GetItem("FOLCUSPO").Specific));
            this.FOLAMDHS = ((SAPbouiCOM.Folder)(this.GetItem("FOLAMDHS").Specific));
            this.FOLATTAC = ((SAPbouiCOM.Folder)(this.GetItem("FOLATTAC").Specific));
            this.MATCUSPO = ((SAPbouiCOM.Matrix)(this.GetItem("MATCUSPO").Specific));
            this.GRIDADNT = ((SAPbouiCOM.Grid)(this.GetItem("GRIDADNT").Specific));
            this.MATATTAC = ((SAPbouiCOM.Matrix)(this.GetItem("MATATTAC").Specific));
            this.ETISUDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETISUDAT").Specific));
            this.STISUDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STISUDAT").Specific));
            this.STDCTYPE = ((SAPbouiCOM.StaticText)(this.GetItem("STDCTYPE").Specific));
            this.CBDCTYPE = ((SAPbouiCOM.ComboBox)(this.GetItem("CBDCTYPE").Specific));
            this.ADDButton = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.ADDButton.PressedBefore += new SAPbouiCOM._IButtonEvents_PressedBeforeEventHandler(this.ADDButton_PressedBefore);
            this.CancelButton = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.STREMRKS = ((SAPbouiCOM.StaticText)(this.GetItem("STREMRKS").Specific));
            this.ETREMRKS = ((SAPbouiCOM.EditText)(this.GetItem("ETREMRKS").Specific));
            this.ETDOCTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCTRY").Specific));
            this.OnCustomInitialize();

        }

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
        private SAPbouiCOM.StaticText STJOBNO;
        private SAPbouiCOM.StaticText STVALUE;
        private SAPbouiCOM.StaticText STFNCOMP;
        private SAPbouiCOM.StaticText STLOCOMP;
        private SAPbouiCOM.StaticText STNETFOB;
        private SAPbouiCOM.StaticText STSTATUS;
        private SAPbouiCOM.StaticText STSCVAL;
        private SAPbouiCOM.StaticText STCURR;
        private SAPbouiCOM.StaticText STFRGCOM;
        private SAPbouiCOM.StaticText STLOCOMM;
        private SAPbouiCOM.StaticText STDOCNUM;
        private SAPbouiCOM.StaticText STDOCDAT;
        private SAPbouiCOM.StaticText STSHIPDT;
        private SAPbouiCOM.StaticText STEXDATE;
        private SAPbouiCOM.StaticText STQTY;
        private SAPbouiCOM.StaticText STB2BLCP;
        private SAPbouiCOM.StaticText STCONVAL;
        private SAPbouiCOM.StaticText STPTRMS1;
        private SAPbouiCOM.StaticText STPTRMS2;
        private SAPbouiCOM.StaticText STIOTRMS;
        private SAPbouiCOM.StaticText STAPRATC;
        private SAPbouiCOM.ComboBox CBCMPANY;
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
        private SAPbouiCOM.EditText ETJOBNO;
        private SAPbouiCOM.EditText ETJOBNAM;
        private SAPbouiCOM.EditText ETVALUE;
        private SAPbouiCOM.EditText ETFNCOMP;
        private SAPbouiCOM.EditText ETLOCOMP;
        private SAPbouiCOM.EditText ETNETFOB;
        private SAPbouiCOM.EditText ETCURR;
        private SAPbouiCOM.EditText ETFRGCOM;
        private SAPbouiCOM.EditText ETLOCOMM;
        private SAPbouiCOM.EditText ETDOCNUM;
        private SAPbouiCOM.EditText ETDOCDAT;
        private SAPbouiCOM.EditText ETSHIPDT;
        private SAPbouiCOM.EditText ETEXDATE;
        private SAPbouiCOM.EditText ETQTY;
        private SAPbouiCOM.EditText ETB2BLCP;
        private SAPbouiCOM.EditText ETCONVAL;
        private SAPbouiCOM.ComboBox CBPTRMS1;
        private SAPbouiCOM.ComboBox CBPTRMS2;
        private SAPbouiCOM.ComboBox CBIOTRMS;
        private SAPbouiCOM.EditText ETAPRATC;
        private SAPbouiCOM.Folder FOLCUSPO;
        private SAPbouiCOM.Folder FOLAMDHS;
        private SAPbouiCOM.Folder FOLATTAC;
        private SAPbouiCOM.Matrix MATCUSPO;
        private SAPbouiCOM.Grid GRIDADNT;
        private SAPbouiCOM.Matrix MATATTAC;
        private SAPbouiCOM.EditText ETISUDAT;
        private SAPbouiCOM.StaticText STISUDAT;
        private SAPbouiCOM.StaticText STDCTYPE;
        private SAPbouiCOM.ComboBox CBDCTYPE;
        private SAPbouiCOM.Button ADDButton;
        private SAPbouiCOM.Button CancelButton;
        private SAPbouiCOM.StaticText STREMRKS;
        private SAPbouiCOM.EditText ETREMRKS;
        private SAPbouiCOM.EditText ETDOCTRY;

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
            return BubbleEvent;
        }



    }
}
