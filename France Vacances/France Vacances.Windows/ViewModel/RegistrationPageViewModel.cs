using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using France_Vacances.Common;
using France_Vacances.Model;

namespace France_Vacances.ViewModel
{
    class RegistrationPageViewModel : DefaultViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        

        public ObservableCollection<UserModel> AddNewUserCollection { get; set; }

        public RelayCommand AddRegistrationCommand { get; set; }

        public RegistrationPageViewModel() 
        {
            AddRegistrationCommand = new RelayCommand(AddRegisterUser);
            AddNewUserCollection = new ObservableCollection<UserModel>();
            
          
            AddNewUserCollection.Add(new UserModel(1, "Frank Andersen", "fha.post@gmail.com", "password", DateTime.Now.ToString()));
            AddNewUserCollection.Add(new UserModel(2, "Test Person", "test@test.com", "test", DateTime.Now.ToString()));

            
        }

        public void AddRegisterUser()
        {
            AddNewUserCollection.Add(new UserModel(ID ,Name,Email,Password,DateTime.Now.ToString()));

            Persistancy.PersistancyService.SaveNotesAsJsonAsync(AddNewUserCollection);

            MessageDialogHelper.Show( "Welcome to France Vacances ","User have been Registered");
        }
    }
}
