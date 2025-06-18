using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LC_ADD_ON.Helper
{
    class Global
    {
        public static SAPbouiCOM.Application G_UI_Application;
        public static SAPbobsCOM.Company oComp; // Varible for company 
        public static GlobalFunction GFunc = new GlobalFunction();
    }
}
