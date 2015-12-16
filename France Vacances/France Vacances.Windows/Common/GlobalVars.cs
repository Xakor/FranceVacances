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

        //Selected City Info
        public static int Global_SelectedCity_cityId;
        public static string Global_SelectedCity_cityName;
        public static double Global_SelectedCity_basePrice;
        public static string Global_SelectedCity_tagline;
        public static string Global_SelectedCity_imgPath;
        public static string Global_SelectedCity_bigDescription;
        
        // Selected apartment info
        public static int Global_selectedApartment_aptId;
        public static int Global_selectedApartment_aptInCity;
        public static string Global_selectedApartment_aptAddress;
        public static string Global_selectedApartment_aptInfo;
        public static double Global_selectedApartment_aptPrice;
        public static string Global_selectedApartment_aptImgPath;
    }
}
