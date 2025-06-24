using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC_ADD_ON.Resources
{
    [FormAttribute("LC_ADD_ON.Resources.SalesContract", "Resources/SalesContract.b1f")]
    class SalesContract : UserFormBase
    {
        public SalesContract()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("STCMPCOD").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBCMPCOD").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCNO").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("STCUSCOD").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("STBRNDCD").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("STISSBNK").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("STSCDESC").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("STSHPDAT").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("STREFENC").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("STISUDAT").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCDAT").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("STNEGBNK").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("STCURR").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("STSCNO").Specific));
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("STSCNDBK").Specific));
            this.StaticText14 = ((SAPbouiCOM.StaticText)(this.GetItem("STAMT").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("STNETFOB").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("STREMVAL").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("STCNSVAL").Specific));
            this.StaticText18 = ((SAPbouiCOM.StaticText)(this.GetItem("STFRGCMP").Specific));
            this.StaticText19 = ((SAPbouiCOM.StaticText)(this.GetItem("STLOCCMP").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("ETCUSCOD").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("ETBRNDCD").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNO").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("ETSCDESC").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("ETAMT").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("ETFRGCMP").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("ETLOCCMP").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("ETCNSVAL").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("ETREMVAL").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("ETNETFOB").Specific));
            this.StaticText20 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_32").Specific));
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("Item_33").Specific));
            this.EditText12 = ((SAPbouiCOM.EditText)(this.GetItem("ETCUSNAM").Specific));
            this.EditText13 = ((SAPbouiCOM.EditText)(this.GetItem("ETBRNDNM").Specific));
            this.StaticText21 = ((SAPbouiCOM.StaticText)(this.GetItem("STCSTTS").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("ETCSTTS").Specific));
            this.EditText15 = ((SAPbouiCOM.EditText)(this.GetItem("ETREFENC").Specific));
            this.StaticText22 = ((SAPbouiCOM.StaticText)(this.GetItem("STFRGCOM").Specific));
            this.StaticText23 = ((SAPbouiCOM.StaticText)(this.GetItem("STLOCCOM").Specific));
            this.EditText16 = ((SAPbouiCOM.EditText)(this.GetItem("ETFRGCOM").Specific));
            this.EditText17 = ((SAPbouiCOM.EditText)(this.GetItem("ETLOCCOM").Specific));
            this.EditText18 = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCNO").Specific));
            this.EditText19 = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCDAT").Specific));
            this.EditText20 = ((SAPbouiCOM.EditText)(this.GetItem("ETISUDAT").Specific));
            this.EditText21 = ((SAPbouiCOM.EditText)(this.GetItem("ETCURR").Specific));
            this.EditText22 = ((SAPbouiCOM.EditText)(this.GetItem("ETNEGBNK").Specific));
            this.EditText23 = ((SAPbouiCOM.EditText)(this.GetItem("ETSCNDBK").Specific));
            this.EditText24 = ((SAPbouiCOM.EditText)(this.GetItem("ETISSBNK").Specific));
            this.StaticText25 = ((SAPbouiCOM.StaticText)(this.GetItem("STEXPDAT").Specific));
            this.StaticText26 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_53").Specific));
            this.StaticText27 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_54").Specific));
            this.StaticText28 = ((SAPbouiCOM.StaticText)(this.GetItem("STAMDTNO").Specific));
            this.EditText25 = ((SAPbouiCOM.EditText)(this.GetItem("Item_56").Specific));
            this.EditText26 = ((SAPbouiCOM.EditText)(this.GetItem("ETSHPDAT").Specific));
            this.EditText27 = ((SAPbouiCOM.EditText)(this.GetItem("ETEXPDAT").Specific));
            this.EditText29 = ((SAPbouiCOM.EditText)(this.GetItem("ETAMDTNO").Specific));
            this.EditText31 = ((SAPbouiCOM.EditText)(this.GetItem("ETISBKNM").Specific));
            this.EditText32 = ((SAPbouiCOM.EditText)(this.GetItem("ETSDBKNM").Specific));
            this.EditText33 = ((SAPbouiCOM.EditText)(this.GetItem("ETNGBKNM").Specific));
            this.StaticText29 = ((SAPbouiCOM.StaticText)(this.GetItem("STBUNIT").Specific));
            this.EditText34 = ((SAPbouiCOM.EditText)(this.GetItem("ETBUNIT").Specific));
            this.StaticText30 = ((SAPbouiCOM.StaticText)(this.GetItem("STSTATUS").Specific));
            this.EditText35 = ((SAPbouiCOM.EditText)(this.GetItem("ETSTATUS").Specific));
            this.StaticText31 = ((SAPbouiCOM.StaticText)(this.GetItem("STCSSTTS").Specific));
            this.EditText36 = ((SAPbouiCOM.EditText)(this.GetItem("ETCSSTTS").Specific));
            this.StaticText24 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_36").Specific));
            this.StaticText32 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_51").Specific));
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_59").Specific));
            this.LinkedButton1 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_61").Specific));
            this.LinkedButton2 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_71").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_73").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_74").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_75").Specific));
            this.Folder3 = ((SAPbouiCOM.Folder)(this.GetItem("Item_76").Specific));
            this.StaticText33 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_77").Specific));
            this.EditText14 = ((SAPbouiCOM.EditText)(this.GetItem("Item_78").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.StaticText34 = ((SAPbouiCOM.StaticText)(this.GetItem("STSHTRMS").Specific));
            this.StaticText35 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_84").Specific));
            this.EditText30 = ((SAPbouiCOM.EditText)(this.GetItem("Item_85").Specific));
            this.StaticText36 = ((SAPbouiCOM.StaticText)(this.GetItem("STTRMSPM").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBTRMSPM").Specific));
            this.ComboBox3 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBSHTRMS").Specific));
            this.ComboBox4 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBMDFSHP").Specific));
            this.StaticText38 = ((SAPbouiCOM.StaticText)(this.GetItem("STDAYS").Specific));
            this.EditText38 = ((SAPbouiCOM.EditText)(this.GetItem("ETDAYS").Specific));
            this.StaticText39 = ((SAPbouiCOM.StaticText)(this.GetItem("STPRTLOD").Specific));
            this.EditText40 = ((SAPbouiCOM.EditText)(this.GetItem("ETINSRCE").Specific));
            this.StaticText41 = ((SAPbouiCOM.StaticText)(this.GetItem("STPRTSHP").Specific));
            this.EditText41 = ((SAPbouiCOM.EditText)(this.GetItem("ETPRTSHP").Specific));
            this.StaticText42 = ((SAPbouiCOM.StaticText)(this.GetItem("STINSRCE").Specific));
            this.StaticText43 = ((SAPbouiCOM.StaticText)(this.GetItem("STPDSCRG").Specific));
            this.StaticText44 = ((SAPbouiCOM.StaticText)(this.GetItem("STCODEST").Specific));
            this.StaticText45 = ((SAPbouiCOM.StaticText)(this.GetItem("STHSCODE").Specific));
            this.EditText45 = ((SAPbouiCOM.EditText)(this.GetItem("ETHSCODE").Specific));
            this.StaticText46 = ((SAPbouiCOM.StaticText)(this.GetItem("STDOCREQ").Specific));
            this.EditText46 = ((SAPbouiCOM.EditText)(this.GetItem("ETDOCTRY").Specific));
            this.EditText47 = ((SAPbouiCOM.EditText)(this.GetItem("Item_110").Specific));
            this.StaticText47 = ((SAPbouiCOM.StaticText)(this.GetItem("STTRMSCN").Specific));
            this.EditText48 = ((SAPbouiCOM.EditText)(this.GetItem("ETTRMSCN").Specific));
            this.StaticText48 = ((SAPbouiCOM.StaticText)(this.GetItem("STMDFSHP").Specific));
            this.StaticText49 = ((SAPbouiCOM.StaticText)(this.GetItem("STNOFYPY").Specific));
            this.EditText49 = ((SAPbouiCOM.EditText)(this.GetItem("ETNOFYPY").Specific));
            this.EditText50 = ((SAPbouiCOM.EditText)(this.GetItem("Item_116").Specific));
            this.EditText51 = ((SAPbouiCOM.EditText)(this.GetItem("Item_117").Specific));
            this.EditText52 = ((SAPbouiCOM.EditText)(this.GetItem("ETPDSCRG").Specific));
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

        private SAPbouiCOM.ComboBox ComboBox0;
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
        private SAPbouiCOM.StaticText StaticText13;
        private SAPbouiCOM.StaticText StaticText14;
        private SAPbouiCOM.StaticText StaticText15;
        private SAPbouiCOM.StaticText StaticText16;
        private SAPbouiCOM.StaticText StaticText17;
        private SAPbouiCOM.StaticText StaticText18;
        private SAPbouiCOM.StaticText StaticText19;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.StaticText StaticText20;
        private SAPbouiCOM.EditText EditText11;
        private SAPbouiCOM.EditText EditText12;
        private SAPbouiCOM.EditText EditText13;
        private SAPbouiCOM.StaticText StaticText21;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.EditText EditText15;
        private SAPbouiCOM.StaticText StaticText22;
        private SAPbouiCOM.StaticText StaticText23;
        private SAPbouiCOM.EditText EditText16;
        private SAPbouiCOM.EditText EditText17;
        private SAPbouiCOM.EditText EditText18;
        private SAPbouiCOM.EditText EditText19;
        private SAPbouiCOM.EditText EditText20;
        private SAPbouiCOM.EditText EditText21;
        private SAPbouiCOM.EditText EditText22;
        private SAPbouiCOM.EditText EditText23;
        private SAPbouiCOM.EditText EditText24;
        private SAPbouiCOM.StaticText StaticText25;
        private SAPbouiCOM.StaticText StaticText26;
        private SAPbouiCOM.StaticText StaticText27;
        private SAPbouiCOM.StaticText StaticText28;
        private SAPbouiCOM.EditText EditText25;
        private SAPbouiCOM.EditText EditText26;
        private SAPbouiCOM.EditText EditText27;
        private SAPbouiCOM.EditText EditText29;
        private SAPbouiCOM.EditText EditText31;
        private SAPbouiCOM.EditText EditText32;
        private SAPbouiCOM.EditText EditText33;
        private SAPbouiCOM.StaticText StaticText29;
        private SAPbouiCOM.EditText EditText34;
        private SAPbouiCOM.StaticText StaticText30;
        private SAPbouiCOM.EditText EditText35;
        private SAPbouiCOM.StaticText StaticText31;
        private SAPbouiCOM.EditText EditText36;
        private SAPbouiCOM.StaticText StaticText24;
        private SAPbouiCOM.StaticText StaticText32;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.LinkedButton LinkedButton1;
        private SAPbouiCOM.LinkedButton LinkedButton2;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.Folder Folder3;
        private SAPbouiCOM.StaticText StaticText33;
        private SAPbouiCOM.EditText EditText14;
        private SAPbouiCOM.Button Button0;

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.StaticText StaticText34;
        private SAPbouiCOM.StaticText StaticText35;
        private SAPbouiCOM.EditText EditText30;
        private SAPbouiCOM.StaticText StaticText36;
        private SAPbouiCOM.ComboBox ComboBox2;
        private SAPbouiCOM.ComboBox ComboBox3;
        private SAPbouiCOM.ComboBox ComboBox4;
        private SAPbouiCOM.StaticText StaticText38;
        private SAPbouiCOM.EditText EditText38;
        private SAPbouiCOM.StaticText StaticText39;
        private SAPbouiCOM.EditText EditText40;
        private SAPbouiCOM.StaticText StaticText41;
        private SAPbouiCOM.EditText EditText41;
        private SAPbouiCOM.StaticText StaticText42;
        private SAPbouiCOM.StaticText StaticText43;
        private SAPbouiCOM.StaticText StaticText44;
        private SAPbouiCOM.StaticText StaticText45;
        private SAPbouiCOM.EditText EditText45;
        private SAPbouiCOM.StaticText StaticText46;
        private SAPbouiCOM.EditText EditText46;
        private SAPbouiCOM.EditText EditText47;
        private SAPbouiCOM.StaticText StaticText47;
        private SAPbouiCOM.EditText EditText48;
        private SAPbouiCOM.StaticText StaticText48;
        private SAPbouiCOM.StaticText StaticText49;
        private SAPbouiCOM.EditText EditText49;
        private SAPbouiCOM.EditText EditText50;
        private SAPbouiCOM.EditText EditText51;
        private SAPbouiCOM.EditText EditText52;

       
    }
}
