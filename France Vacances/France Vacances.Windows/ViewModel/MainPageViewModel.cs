using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
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

        public RelayCommand ApartmentCommand { get; set; }

        public  CityModel SelectedCity
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
            GlobalVars.Global_SelectedCity_cityId = SelectedCity.CityId;

            ApartmentCommand = new RelayCommand(DoViewApartments);

        }

        public void DoViewApartments()
        {
            GlobalVars.Global_SelectedCity_cityId = SelectedCity.CityId;
        }
    }
}
