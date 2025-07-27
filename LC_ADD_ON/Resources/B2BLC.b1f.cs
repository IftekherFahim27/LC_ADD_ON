using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC_ADD_ON.Resources
{
    [FormAttribute("LC_ADD_ON.Resources.B2BLC", "Resources/B2BLC.b1f")]
    class B2BLC : UserFormBase
    {
        public B2BLC()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.STCOMPNY = ((SAPbouiCOM.StaticText)(this.GetItem("STCOMPNY").Specific));
            this.STTYTRNS = ((SAPbouiCOM.StaticText)(this.GetItem("STTYTRNS").Specific));
            this.STB2LCNO = ((SAPbouiCOM.StaticText)(this.GetItem("STB2LCNO").Specific));
            this.STAMDNO = ((SAPbouiCOM.StaticText)(this.GetItem("STAMDNO").Specific));
            this.STDESC = ((SAPbouiCOM.StaticText)(this.GetItem("STDESC").Specific));
            this.STREFRNC = ((SAPbouiCOM.StaticText)(this.GetItem("STREFRNC").Specific));
            this.STITEMNO = ((SAPbouiCOM.StaticText)(this.GetItem("STITEMNO").Specific));
            this.STITMQTY = ((SAPbouiCOM.StaticText)(this.GetItem("STITMQTY").Specific));
            this.STSUPCOD = ((SAPbouiCOM.StaticText)(this.GetItem("STSUPCOD").Specific));
            this.STNEGBNK = ((SAPbouiCOM.StaticText)(this.GetItem("STNEGBNK").Specific));
            this.STVALUE = ((SAPbouiCOM.StaticText)(this.GetItem("STVALUE").Specific));
            this.STBNKCHG = ((SAPbouiCOM.StaticText)(this.GetItem("STBNKCHG").Specific));
            this.STSUPBNK = ((SAPbouiCOM.StaticText)(this.GetItem("STSUPBNK").Specific));
            this.STEXPCON = ((SAPbouiCOM.StaticText)(this.GetItem("STEXPCON").Specific));
            this.STCURR = ((SAPbouiCOM.StaticText)(this.GetItem("STCURR").Specific));
            this.STCONTRY = ((SAPbouiCOM.StaticText)(this.GetItem("STCONTRY").Specific));
            this.STSHPMNT = ((SAPbouiCOM.StaticText)(this.GetItem("STSHPMNT").Specific));
            this.STSTATUS = ((SAPbouiCOM.StaticText)(this.GetItem("STSTATUS").Specific));
            this.STDOCNO = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCNO").Specific));
            this.STCOMKDT = ((SAPbouiCOM.StaticText)(this.GetItem("STCOMKDT").Specific));
            this.STISUDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STISUDAT").Specific));
            this.STSHPDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STSHPDAT").Specific));
            this.STEXPDAT = ((SAPbouiCOM.StaticText)(this.GetItem("STEXPDAT").Specific));
            this.STPMTRMS = ((SAPbouiCOM.StaticText)(this.GetItem("STPMTRMS").Specific));
            this.STDAY = ((SAPbouiCOM.StaticText)(this.GetItem("STDAY").Specific));
            this.STINCTRS = ((SAPbouiCOM.StaticText)(this.GetItem("STINCTRS").Specific));
            this.STPOL = ((SAPbouiCOM.StaticText)(this.GetItem("STPOL").Specific));
            this.STPOD = ((SAPbouiCOM.StaticText)(this.GetItem("STPOD").Specific));
            this.STHSCODE = ((SAPbouiCOM.StaticText)(this.GetItem("STHSCODE").Specific));
            this.STFCACCT = ((SAPbouiCOM.StaticText)(this.GetItem("STFCACCT").Specific));
            this.STBUNIT = ((SAPbouiCOM.StaticText)(this.GetItem("STBUNIT").Specific));
            this.STMMODE = ((SAPbouiCOM.StaticText)(this.GetItem("STMMODE").Specific));
            this.STCMMODE = ((SAPbouiCOM.StaticText)(this.GetItem("STCMMODE").Specific));

            this.CBCOMPNY = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCOMPNY").Specific));
            this.CBTYTRNS = ((SAPbouiCOM.ComboBox)(this.GetItem("CBTYTRNS").Specific));
            this.CBCONTRY = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCONTRY").Specific));
            this.ETSHPMNT = ((SAPbouiCOM.ComboBox)(this.GetItem("ETSHPMNT").Specific));
            this.CBMMODE = ((SAPbouiCOM.ComboBox)(this.GetItem("CBMMODE").Specific));
            this.CBPMTRMS = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPMTRMS").Specific));
            this.CBDAY = ((SAPbouiCOM.ComboBox)(this.GetItem("CBDAY").Specific));
            this.CBINCTRS = ((SAPbouiCOM.ComboBox)(this.GetItem("CBINCTRS").Specific));

            this.ETB2LCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETB2LCNO").Specific));
            this.ETAMDNO = ((SAPbouiCOM.EditText)(this.GetItem("ETAMDNO").Specific));
            this.ETAMDDT = ((SAPbouiCOM.EditText)(this.GetItem("ETAMDDT").Specific));
            this.CBCMMODE = ((SAPbouiCOM.EditText)(this.GetItem("CBCMMODE").Specific));
            this.ETDESC = ((SAPbouiCOM.EditText)(this.GetItem("ETDESC").Specific));
            this.ETREFRNC = ((SAPbouiCOM.EditText)(this.GetItem("ETREFRNC").Specific));
            this.ETITEMNO = ((SAPbouiCOM.EditText)(this.GetItem("ETITEMNO").Specific));
            this.ETITMQTY = ((SAPbouiCOM.EditText)(this.GetItem("ETITMQTY").Specific));
            this.ETEXPCON = ((SAPbouiCOM.EditText)(this.GetItem("ETEXPCON").Specific));
            this.ETSUPCOD = ((SAPbouiCOM.EditText)(this.GetItem("ETSUPCOD").Specific));
            this.ETCURR = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
            this.ETNEGBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETNEGBNK").Specific));
            this.ETBNKNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETBNKNAM").Specific));
            this.ETACCNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETACCNAM").Specific));
            this.ETVALUE = ((SAPbouiCOM.EditText)(this.GetItem("ETVALUE").Specific));
            this.ETBNKCHG = ((SAPbouiCOM.EditText)(this.GetItem("ETBNKCHG").Specific));
            this.ETSUPBNK = ((SAPbouiCOM.EditText)(this.GetItem("ETSUPBNK").Specific));
            this.ETSUPNAM = ((SAPbouiCOM.EditText)(this.GetItem("ETSUPNAM").Specific));
            this.ETSTFULL = ((SAPbouiCOM.EditText)(this.GetItem("ETSTFULL").Specific));
            this.ETDOCNO = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCNO").Specific));
            this.ETCOMKDT = ((SAPbouiCOM.EditText)(this.GetItem("ETCOMKDT").Specific));
            this.ETISUDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETISUDAT").Specific));
            this.ETSHPDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETSHPDAT").Specific));
            this.ETEXPDAT = ((SAPbouiCOM.EditText)(this.GetItem("ETEXPDAT").Specific));
            this.ETPOL = ((SAPbouiCOM.EditText)(this.GetItem("ETPOL").Specific));
            this.ETPOD = ((SAPbouiCOM.EditText)(this.GetItem("ETPOD").Specific));
            this.ETHSCODE = ((SAPbouiCOM.EditText)(this.GetItem("ETHSCODE").Specific));
            this.ETFCACCT = ((SAPbouiCOM.EditText)(this.GetItem("ETFCACCT").Specific));
            this.ETBUNIT = ((SAPbouiCOM.EditText)(this.GetItem("ETBUNIT").Specific));
            this.ETDOCTRY = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCTRY").Specific));
            this.ETSTATUS = ((SAPbouiCOM.EditText)(this.GetItem("ETSTATUS").Specific));



            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_77").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_78").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_79").Specific));
            this.Folder3 = ((SAPbouiCOM.Folder)(this.GetItem("Item_80").Specific));
            this.Folder4 = ((SAPbouiCOM.Folder)(this.GetItem("Item_81").Specific));
            this.Folder5 = ((SAPbouiCOM.Folder)(this.GetItem("Item_82").Specific));
             
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_83").Specific));
            this.Matrix1 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_84").Specific));
            this.Matrix2 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_85").Specific));
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_25").Specific));
            this.Matrix3 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_37").Specific));
           
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.StaticText StaticText0;

        private void OnCustomInitialize()
        {

        }

        // EditTexts
        private SAPbouiCOM.EditText ETB2LCNO;
        private SAPbouiCOM.EditText ETAMDNO;
        private SAPbouiCOM.EditText ETAMDDT;
        private SAPbouiCOM.EditText CBCMMODE;
        private SAPbouiCOM.EditText ETDESC;
        private SAPbouiCOM.EditText ETREFRNC;
        private SAPbouiCOM.EditText ETITEMNO;
        private SAPbouiCOM.EditText ETITMQTY;
        private SAPbouiCOM.EditText ETEXPCON;
        private SAPbouiCOM.EditText ETSUPCOD;
        private SAPbouiCOM.EditText ETCURR;
        private SAPbouiCOM.EditText ETNEGBNK;
        private SAPbouiCOM.EditText ETBNKNAM;
        private SAPbouiCOM.EditText ETACCNAM;
        private SAPbouiCOM.EditText ETVALUE;
        private SAPbouiCOM.EditText ETBNKCHG;
        private SAPbouiCOM.EditText ETSUPBNK;
        private SAPbouiCOM.EditText ETSUPNAM;
        private SAPbouiCOM.EditText ETSTFULL;
        private SAPbouiCOM.EditText ETDOCNO;
        private SAPbouiCOM.EditText ETCOMKDT;
        private SAPbouiCOM.EditText ETISUDAT;
        private SAPbouiCOM.EditText ETSHPDAT;
        private SAPbouiCOM.EditText ETEXPDAT;
        private SAPbouiCOM.EditText ETPOL;
        private SAPbouiCOM.EditText ETPOD;
        private SAPbouiCOM.EditText ETHSCODE;
        private SAPbouiCOM.EditText ETFCACCT;
        private SAPbouiCOM.EditText ETBUNIT;
        private SAPbouiCOM.EditText ETDOCTRY;
        private SAPbouiCOM.EditText ETSTATUS;

        // ComboBoxes
        private SAPbouiCOM.ComboBox CBCOMPNY;
        private SAPbouiCOM.ComboBox CBTYTRNS;
        private SAPbouiCOM.ComboBox CBCONTRY;
        private SAPbouiCOM.ComboBox ETSHPMNT;
        private SAPbouiCOM.ComboBox CBMMODE;
        private SAPbouiCOM.ComboBox CBPMTRMS;
        private SAPbouiCOM.ComboBox CBDAY;
        private SAPbouiCOM.ComboBox CBINCTRS;

        // StaticTexts
        private SAPbouiCOM.StaticText STCOMPNY;
        private SAPbouiCOM.StaticText STTYTRNS;
        private SAPbouiCOM.StaticText STB2LCNO;
        private SAPbouiCOM.StaticText STAMDNO;
        private SAPbouiCOM.StaticText STDESC;
        private SAPbouiCOM.StaticText STREFRNC;
        private SAPbouiCOM.StaticText STITEMNO;
        private SAPbouiCOM.StaticText STITMQTY;
        private SAPbouiCOM.StaticText STSUPCOD;
        private SAPbouiCOM.StaticText STNEGBNK;
        private SAPbouiCOM.StaticText STVALUE;
        private SAPbouiCOM.StaticText STBNKCHG;
        private SAPbouiCOM.StaticText STSUPBNK;
        private SAPbouiCOM.StaticText STEXPCON;
        private SAPbouiCOM.StaticText STCURR;
        private SAPbouiCOM.StaticText STCONTRY;
        private SAPbouiCOM.StaticText STSHPMNT;
        private SAPbouiCOM.StaticText STSTATUS;
        private SAPbouiCOM.StaticText STDOCNO;
        private SAPbouiCOM.StaticText STCOMKDT;
        private SAPbouiCOM.StaticText STISUDAT;
        private SAPbouiCOM.StaticText STSHPDAT;
        private SAPbouiCOM.StaticText STEXPDAT;
        private SAPbouiCOM.StaticText STPMTRMS;
        private SAPbouiCOM.StaticText STDAY;
        private SAPbouiCOM.StaticText STINCTRS;
        private SAPbouiCOM.StaticText STPOL;
        private SAPbouiCOM.StaticText STPOD;
        private SAPbouiCOM.StaticText STHSCODE;
        private SAPbouiCOM.StaticText STFCACCT;
        private SAPbouiCOM.StaticText STBUNIT;
        private SAPbouiCOM.StaticText STMMODE;
        private SAPbouiCOM.StaticText STCMMODE;





        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.Folder Folder3;
        private SAPbouiCOM.Folder Folder4;
        private SAPbouiCOM.Folder Folder5;
        private SAPbouiCOM.Matrix Matrix0;
        private SAPbouiCOM.Matrix Matrix1;
        private SAPbouiCOM.Matrix Matrix2;
        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.Matrix Matrix3;
       
    }
}
