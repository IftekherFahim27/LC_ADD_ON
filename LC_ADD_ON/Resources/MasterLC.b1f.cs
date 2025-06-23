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
            this.ETSTATUS = ((SAPbouiCOM.EditText)(this.GetItem("ETSTATUS").Specific));
            this.ETCDNAME = ((SAPbouiCOM.EditText)(this.GetItem("ETCDNAME").Specific));
            this.ETSCVAL = ((SAPbouiCOM.EditText)(this.GetItem("ETSCVAL").Specific));
            this.ETSCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNO").Specific));
            this.ETSCNTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNTRY").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_37").Specific));
            this.ETDESC = ((SAPbouiCOM.EditText)(this.GetItem("ETDESC").Specific));
            this.ETADNTNO = ((SAPbouiCOM.EditText)(this.GetItem("ETADNTNO").Specific));
            this.ETISSBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETISSBNK").Specific));
            this.ETIBNKNM = ((SAPbouiCOM.EditText)(this.GetItem("ETIBNKNM").Specific));
            this.ETNEGBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETNEGBNK").Specific));
            this.ETNGBNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETNGBNAM").Specific));
            this.ETJOBNO = ((SAPbouiCOM.EditText)(this.GetItem("ETJOBNO").Specific));
            this.ETJOBNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETJOBNAM").Specific));
            this.ETVALUE = ((SAPbouiCOM.EditText)(this.GetItem("ETVALUE").Specific));
            this.ETFNCOMP = ((SAPbouiCOM.EditText)(this.GetItem("ETFNCOMP").Specific));
            this.ETLOCOMP = ((SAPbouiCOM.EditText)(this.GetItem("ETLOCOMP").Specific));
            this.ETNETFOB = ((SAPbouiCOM.EditText)(this.GetItem("ETNETFOB").Specific));
            this.ETCURR = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
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
        private SAPbouiCOM.EditText EditText6;
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
    }
}
