using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using France_Vacances.Annotations;
using France_Vacances.Common;
using France_Vacances.Model;
using France_Vacances.Persistancy;
using France_Vacances.View;

namespace France_Vacances.ViewModel
{
    class LoginViewModel : DefaultViewModel
    {
        // Login Page ViewModel Code
        public string Email { get; set; }
        public string Password { get; set; }

        public ObservableCollection<UserModel> UserModels { get; set; } 

        public RelayCommand LoginCommand { get; set; }

        public LoginViewModel() 
        {
            LoginCommand = new RelayCommand(DoLoginUser);
        }

        public void DoLoginUser()
        {
            var dataList = PersistancyService.LoadNotesFromJsonAsync();

            foreach (var UserModel in dataList.Result)
            {
                if (UserModel.Email == Email && UserModel.Password == Password)
                {
                    // Do something when you succesfully log in
                    GlobalVars.Global_LoggedInBool = true;
                    GlobalVars.Global_LoggedInName = UserModel.Name;
                    
                }
                // Do something when log in fails
            }
        }
    }
}
