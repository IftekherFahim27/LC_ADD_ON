using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC_ADD_ON.Resources
{
    [FormAttribute("LC_ADD_ON.Resources.LC_Ammendment", "Resources/LC_Ammendment.b1f")]
    class LC_Ammendment : UserFormBase
    {
        public LC_Ammendment()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("STRMARKS").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("ETRMARKS").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("STCMPANY").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("STCUSTMR").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("STDCTYPE").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("STSCNO").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("STLCNO").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("STDESC").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("STADNTNO").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("STISSBNK").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("STNEGBNK").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("STVALUE").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("STSTATUS").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("STCURR").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCMPANY").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("ETCUSTMR").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNO").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("ETLCNO").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("ETDESC").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("ETADNTNO").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("ETISSBNK").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("ETNEGBNK").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("ETVALUE").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("ETSTNAM").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBDCTYPE").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("ETCDNAME").Specific));
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("Item_28").Specific));
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("STSCVAL").Specific));
            this.StaticText14 = ((SAPbouiCOM.StaticText)(this.GetItem("STRSCAMT").Specific));
            this.EditText12 = ((SAPbouiCOM.EditText)(this.GetItem("ETSCVAL").Specific));
            this.EditText13 = ((SAPbouiCOM.EditText)(this.GetItem("ETRSCAMT").Specific));
            this.EditText14 = ((SAPbouiCOM.EditText)(this.GetItem("ETIBNKNM").Specific));
            this.EditText15 = ((SAPbouiCOM.EditText)(this.GetItem("ETNGBNAM").Specific));
            this.EditText16 = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCNUM").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCDAT").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("STISUDAT").Specific));
            this.StaticText18 = ((SAPbouiCOM.StaticText)(this.GetItem("STSHIPDT").Specific));
            this.StaticText19 = ((SAPbouiCOM.StaticText)(this.GetItem("STEXDATE").Specific));
            this.StaticText20 = ((SAPbouiCOM.StaticText)(this.GetItem("STB2BLCP").Specific));
            this.StaticText21 = ((SAPbouiCOM.StaticText)(this.GetItem("STCONVAL").Specific));
            this.StaticText22 = ((SAPbouiCOM.StaticText)(this.GetItem("STPTRMS1").Specific));
            this.StaticText23 = ((SAPbouiCOM.StaticText)(this.GetItem("STPTRMS2").Specific));
            this.EditText17 = ((SAPbouiCOM.EditText)(this.GetItem("Item_45").Specific));
            this.EditText18 = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCDAT").Specific));
            this.EditText19 = ((SAPbouiCOM.EditText)(this.GetItem("ETISUDAT").Specific));
            this.EditText20 = ((SAPbouiCOM.EditText)(this.GetItem("ETSHIPDT").Specific));
            this.EditText21 = ((SAPbouiCOM.EditText)(this.GetItem("ETEXDATE").Specific));
            this.EditText22 = ((SAPbouiCOM.EditText)(this.GetItem("ETB2BLCP").Specific));
            this.EditText23 = ((SAPbouiCOM.EditText)(this.GetItem("ETCONVAL").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS1").Specific));
            this.ComboBox3 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBPTRMS2").Specific));
            this.ComboBox4 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBIOTRMS").Specific));
            this.StaticText24 = ((SAPbouiCOM.StaticText)(this.GetItem("STIOTRMS").Specific));
            this.EditText27 = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCTRY").Specific));
            this.EditText28 = ((SAPbouiCOM.EditText)(this.GetItem("ETSTAT").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_62").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_63").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_64").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("MATCUSPO").Specific));
            this.Matrix1 = ((SAPbouiCOM.Matrix)(this.GetItem("MATATTAC").Specific));
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("BRWSBTN").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("DISPBTN").Specific));
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("DELBTN").Specific));
            this.Matrix2 = ((SAPbouiCOM.Matrix)(this.GetItem("MATAMDHS").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Button Button0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.StaticText StaticText9;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.StaticText StaticText11;
        private SAPbouiCOM.StaticText StaticText12;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.EditText EditText11;
        private SAPbouiCOM.StaticText StaticText13;
        private SAPbouiCOM.StaticText StaticText14;
        private SAPbouiCOM.EditText EditText12;
        private SAPbouiCOM.EditText EditText13;
        private SAPbouiCOM.EditText EditText14;
        private SAPbouiCOM.EditText EditText15;
        private SAPbouiCOM.EditText EditText16;
        private SAPbouiCOM.StaticText StaticText15;
        private SAPbouiCOM.StaticText StaticText16;
        private SAPbouiCOM.StaticText StaticText17;
        private SAPbouiCOM.StaticText StaticText18;
        private SAPbouiCOM.StaticText StaticText19;
        private SAPbouiCOM.StaticText StaticText20;
        private SAPbouiCOM.StaticText StaticText21;
        private SAPbouiCOM.StaticText StaticText22;
        private SAPbouiCOM.StaticText StaticText23;
        private SAPbouiCOM.EditText EditText17;
        private SAPbouiCOM.EditText EditText18;
        private SAPbouiCOM.EditText EditText19;
        private SAPbouiCOM.EditText EditText20;
        private SAPbouiCOM.EditText EditText21;
        private SAPbouiCOM.EditText EditText22;
        private SAPbouiCOM.EditText EditText23;
        private SAPbouiCOM.ComboBox ComboBox2;
        private SAPbouiCOM.ComboBox ComboBox3;
        private SAPbouiCOM.ComboBox ComboBox4;
        private SAPbouiCOM.StaticText StaticText24;
        private SAPbouiCOM.EditText EditText27;
        private SAPbouiCOM.EditText EditText28;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.Matrix Matrix0;
        private SAPbouiCOM.Matrix Matrix1;
        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Button Button4;
        private SAPbouiCOM.Matrix Matrix2;
    }
}
