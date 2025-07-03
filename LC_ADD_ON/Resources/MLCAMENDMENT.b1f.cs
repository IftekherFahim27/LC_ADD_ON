using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LC_ADD_ON.Helper;

namespace LC_ADD_ON.Resources
{
    [FormAttribute("LC_ADD_ON.Resources.MLCAMENDMENT", "Resources/MLCAMENDMENT.b1f")]
    class MLCAMENDMENT : UserFormBase
    {
        public MLCAMENDMENT()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
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
            this.ETCUSTMR = ((SAPbouiCOM.EditText)(this.GetItem("ETCUSTMR").Specific));
            this.ETCUSTMR.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETCUSTMR_ChooseFromListAfter);
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
            this.ETVALUE = ((SAPbouiCOM.EditText)(this.GetItem("ETVALUE").Specific));
            this.ETCURR = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
            this.ETCURR.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.ETCURR_ChooseFromListAfter);
            this.STDCTYPE = ((SAPbouiCOM.StaticText)(this.GetItem("STDCTYPE").Specific));
            this.ETDOCNUM = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCNUM").Specific));
            this.ETDOCDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCDAT").Specific));
            this.ETSHIPDT = ((SAPbouiCOM.EditText)(this.GetItem("ETSHIPDT").Specific));
            this.ETEXDATE = ((SAPbouiCOM.EditText)(this.GetItem("ETEXDATE").Specific));
            this.ETB2BLCP = ((SAPbouiCOM.EditText)(this.GetItem("ETB2BLCP").Specific));
            this.ETCONVAL = ((SAPbouiCOM.EditText)(this.GetItem("ETCONVAL").Specific));
            this.CBPTRMS1 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS1").Specific));
            this.CBPTRMS2 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS2").Specific));
            this.CBIOTRMS = ((SAPbouiCOM.ComboBox)(this.GetItem("CBIOTRMS").Specific));
            this.ETSTFULL = ((SAPbouiCOM.EditText)(this.GetItem("ETSTFULL").Specific));
            this.ETISUDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETISUDAT").Specific));
            this.STISUDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STISUDAT").Specific));
            this.CBDCTYPE = ((SAPbouiCOM.ComboBox)(this.GetItem("CBDCTYPE").Specific));
            this.STRSCAMT = ((SAPbouiCOM.StaticText)(this.GetItem("STRSCAMT").Specific));
            this.ETRSCAMT = ((SAPbouiCOM.EditText)(this.GetItem("ETRSCAMT").Specific));
            this.STCMPANY = ((SAPbouiCOM.StaticText)(this.GetItem("STCMPANY").Specific));
            this.CBCMPANY = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCMPANY").Specific));
            this.FOLCUSPO = ((SAPbouiCOM.Folder)(this.GetItem("FOLCUSPO").Specific));
            this.FOLAMDHS = ((SAPbouiCOM.Folder)(this.GetItem("FOLAMDHS").Specific));
            this.FOLATTAC = ((SAPbouiCOM.Folder)(this.GetItem("FOLATTAC").Specific));
            this.ADDButton = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.CancelButton = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.STREMRKS = ((SAPbouiCOM.StaticText)(this.GetItem("STREMRKS").Specific));
            this.ETREMRKS = ((SAPbouiCOM.EditText)(this.GetItem("ETREMRKS").Specific));
            this.MATCUSPO = ((SAPbouiCOM.Matrix)(this.GetItem("MATCUSPO").Specific));
            this.GRIDADNT = ((SAPbouiCOM.Grid)(this.GetItem("GRIDADNT").Specific));
            this.MATATTAC = ((SAPbouiCOM.Matrix)(this.GetItem("MATATTAC").Specific));
            this.BRWSBTN = ((SAPbouiCOM.Button)(this.GetItem("BRWSBTN").Specific));
            this.DISPBTN = ((SAPbouiCOM.Button)(this.GetItem("DISPBTN").Specific));
            this.DELBTN = ((SAPbouiCOM.Button)(this.GetItem("DELBTN").Specific));
            this.ETDOCTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCTRY").Specific));
            this.ETSTATUS = ((SAPbouiCOM.EditText)(this.GetItem("ETSTATUS").Specific));
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
        private SAPbouiCOM.StaticText STDCTYPE;
        private SAPbouiCOM.StaticText STISUDAT;
        private SAPbouiCOM.StaticText STRSCAMT;
        private SAPbouiCOM.StaticText STCMPANY;
        private SAPbouiCOM.StaticText STREMRKS;

        private SAPbouiCOM.EditText ETCUSTMR;
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
        private SAPbouiCOM.EditText ETSTFULL;
        private SAPbouiCOM.EditText ETISUDAT;
        private SAPbouiCOM.EditText ETRSCAMT;
        private SAPbouiCOM.EditText ETREMRKS;
        private SAPbouiCOM.EditText ETDOCTRY;
        private SAPbouiCOM.EditText ETSTATUS;

        private SAPbouiCOM.ComboBox CBPTRMS1;
        private SAPbouiCOM.ComboBox CBPTRMS2;
        private SAPbouiCOM.ComboBox CBIOTRMS;
        private SAPbouiCOM.ComboBox CBDCTYPE;
        private SAPbouiCOM.ComboBox CBCMPANY;



        private SAPbouiCOM.Folder FOLCUSPO;
        private SAPbouiCOM.Folder FOLAMDHS;
        private SAPbouiCOM.Folder FOLATTAC;

       
        private SAPbouiCOM.Grid GRIDADNT;

        private SAPbouiCOM.Matrix MATCUSPO;
        private SAPbouiCOM.Matrix MATATTAC;

        private SAPbouiCOM.Button ADDButton;
        private SAPbouiCOM.Button CancelButton;
        private SAPbouiCOM.Button BRWSBTN;
        private SAPbouiCOM.Button DISPBTN;
        private SAPbouiCOM.Button DELBTN;

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

                //cflflag = true;

                ////MAtrix Load
                //SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);
                //SAPbouiCOM.DBDataSource DBDataSourceLine = (SAPbouiCOM.DBDataSource)oForm.DataSources.DBDataSources.Item("@FIL_LCM2");
                //SAPbouiCOM.Matrix MATCUSPO = (SAPbouiCOM.Matrix)oForm.Items.Item("MATCUSPO").Specific;


                //if (MATCUSPO.VisualRowCount == 0 && cflflag == true)
                //{
                //    Global.GFunc.SetNewLine(MATCUSPO, DBDataSourceLine, 1, "");// added the line for matrix 1
                //}


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
    }
}
