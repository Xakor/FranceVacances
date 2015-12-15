using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using France_Vacances.Common;
using France_Vacances.Model;

namespace France_Vacances.ViewModel
{
    public class MainPageViewModel : DefaultViewModel
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
    }
}
