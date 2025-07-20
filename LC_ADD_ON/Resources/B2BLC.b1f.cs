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
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_6").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_7").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_10").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_12").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_13").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_14").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_15").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_16").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_17").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_18").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_19").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_20").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_21").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_22").Specific));
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_23").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_24").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("Item_26").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("Item_27").Specific));
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("Item_28").Specific));
            this.EditText12 = ((SAPbouiCOM.EditText)(this.GetItem("Item_29").Specific));
            this.EditText13 = ((SAPbouiCOM.EditText)(this.GetItem("Item_30").Specific));
            this.EditText14 = ((SAPbouiCOM.EditText)(this.GetItem("Item_31").Specific));
            this.EditText15 = ((SAPbouiCOM.EditText)(this.GetItem("Item_32").Specific));
            this.EditText16 = ((SAPbouiCOM.EditText)(this.GetItem("Item_33").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_34").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_35").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_36").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_39").Specific));
            this.ComboBox3 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_40").Specific));
            this.EditText19 = ((SAPbouiCOM.EditText)(this.GetItem("Item_41").Specific));
            this.ComboBox4 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_42").Specific));
            this.StaticText18 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_43").Specific));
            this.EditText20 = ((SAPbouiCOM.EditText)(this.GetItem("Item_44").Specific));
            this.StaticText19 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_45").Specific));
            this.StaticText20 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_46").Specific));
            this.StaticText21 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_47").Specific));
            this.StaticText22 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_48").Specific));
            this.StaticText23 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_49").Specific));
            this.StaticText24 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_50").Specific));
            this.StaticText25 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_51").Specific));
            this.StaticText26 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_52").Specific));
            this.StaticText27 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_53").Specific));
            this.StaticText28 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_54").Specific));
            this.StaticText29 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_55").Specific));
            this.StaticText30 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_56").Specific));
            this.StaticText31 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_57").Specific));
            this.EditText21 = ((SAPbouiCOM.EditText)(this.GetItem("Item_58").Specific));
            this.EditText22 = ((SAPbouiCOM.EditText)(this.GetItem("Item_59").Specific));
            this.EditText23 = ((SAPbouiCOM.EditText)(this.GetItem("Item_60").Specific));
            this.EditText24 = ((SAPbouiCOM.EditText)(this.GetItem("Item_61").Specific));
            this.EditText25 = ((SAPbouiCOM.EditText)(this.GetItem("Item_62").Specific));
            this.EditText29 = ((SAPbouiCOM.EditText)(this.GetItem("Item_66").Specific));
            this.EditText30 = ((SAPbouiCOM.EditText)(this.GetItem("Item_67").Specific));
            this.EditText31 = ((SAPbouiCOM.EditText)(this.GetItem("Item_68").Specific));
            this.EditText32 = ((SAPbouiCOM.EditText)(this.GetItem("Item_69").Specific));
            this.EditText33 = ((SAPbouiCOM.EditText)(this.GetItem("Item_70").Specific));
            this.ComboBox5 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_71").Specific));
            this.ComboBox6 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_72").Specific));
            this.ComboBox7 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_73").Specific));
            this.EditText34 = ((SAPbouiCOM.EditText)(this.GetItem("Item_74").Specific));
            this.EditText35 = ((SAPbouiCOM.EditText)(this.GetItem("Item_75").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_77").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_78").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_79").Specific));
            this.Folder3 = ((SAPbouiCOM.Folder)(this.GetItem("Item_80").Specific));
            this.Folder4 = ((SAPbouiCOM.Folder)(this.GetItem("Item_81").Specific));
            this.Folder5 = ((SAPbouiCOM.Folder)(this.GetItem("Item_82").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_83").Specific));
            this.Matrix1 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_84").Specific));
            this.Matrix2 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_85").Specific));
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
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.StaticText StaticText13;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.EditText EditText11;
        private SAPbouiCOM.EditText EditText12;
        private SAPbouiCOM.EditText EditText13;
        private SAPbouiCOM.EditText EditText14;
        private SAPbouiCOM.EditText EditText15;
        private SAPbouiCOM.EditText EditText16;
        private SAPbouiCOM.StaticText StaticText15;
        private SAPbouiCOM.StaticText StaticText16;
        private SAPbouiCOM.StaticText StaticText17;
        private SAPbouiCOM.ComboBox ComboBox2;
        private SAPbouiCOM.ComboBox ComboBox3;
        private SAPbouiCOM.EditText EditText19;
        private SAPbouiCOM.ComboBox ComboBox4;
        private SAPbouiCOM.StaticText StaticText18;
        private SAPbouiCOM.EditText EditText20;
        private SAPbouiCOM.StaticText StaticText19;
        private SAPbouiCOM.StaticText StaticText20;
        private SAPbouiCOM.StaticText StaticText21;
        private SAPbouiCOM.StaticText StaticText22;
        private SAPbouiCOM.StaticText StaticText23;
        private SAPbouiCOM.StaticText StaticText24;
        private SAPbouiCOM.StaticText StaticText25;
        private SAPbouiCOM.StaticText StaticText26;
        private SAPbouiCOM.StaticText StaticText27;
        private SAPbouiCOM.StaticText StaticText28;
        private SAPbouiCOM.StaticText StaticText29;
        private SAPbouiCOM.StaticText StaticText30;
        private SAPbouiCOM.StaticText StaticText31;
        private SAPbouiCOM.EditText EditText21;
        private SAPbouiCOM.EditText EditText22;
        private SAPbouiCOM.EditText EditText23;
        private SAPbouiCOM.EditText EditText24;
        private SAPbouiCOM.EditText EditText25;
        private SAPbouiCOM.EditText EditText29;
        private SAPbouiCOM.EditText EditText30;
        private SAPbouiCOM.EditText EditText31;
        private SAPbouiCOM.EditText EditText32;
        private SAPbouiCOM.EditText EditText33;
        private SAPbouiCOM.ComboBox ComboBox5;
        private SAPbouiCOM.ComboBox ComboBox6;
        private SAPbouiCOM.ComboBox ComboBox7;
        private SAPbouiCOM.EditText EditText34;
        private SAPbouiCOM.EditText EditText35;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.Folder Folder3;
        private SAPbouiCOM.Folder Folder4;
        private SAPbouiCOM.Folder Folder5;
        private SAPbouiCOM.Matrix Matrix0;
        private SAPbouiCOM.Matrix Matrix1;
        private SAPbouiCOM.Matrix Matrix2;
    }
}
