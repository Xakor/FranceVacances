using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Common
{
    public class GlobalVars
    {

        //Vars related to user logins
        public static bool Global_LoggedInBool = false;
        public static string Global_LoggedInName = null;

        //Vars related to selected elemtns
        public static int Global_SelectedCity;
        public static int Global_selectedApartment;
    }
}
