using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using France_Vacances.Annotations;
using France_Vacances.Common;
using France_Vacances.Model;

namespace France_Vacances.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        // Login Page ViewModel Code
        public RelayCommand LoginCommand { get; set; }

        private UserModel _existingUser;

        public UserModel  ExistingUser 
        {
            get { return _existingUser; }
            set
            {
                _existingUser = value;
                OnPropertyChanged();
            }
        } 

        //constructor
        public LoginViewModel()
        {

        }
        
        public void DoLogin()
        {
            string loginResult = "æsodjfk";

            
        }
        
        // INotifyPropertyChanged Interface Integration
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
