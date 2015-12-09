using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using France_Vacances.Annotations;
using France_Vacances.Model;

namespace France_Vacances.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CityModel> _citiesCollection;
        private CityModel _selectedCity;

        public ObservableCollection<CityModel> CitiesCollection
        {
            get { return _citiesCollection; }
            set { _citiesCollection = value; }
        }

        public CityModel SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                _selectedCity = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            CitiesCollection = new ObservableCollection<CityModel>(CityModel.CityModels());
            SelectedCity = CitiesCollection[0];
            
        }

        // inotify interface
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
