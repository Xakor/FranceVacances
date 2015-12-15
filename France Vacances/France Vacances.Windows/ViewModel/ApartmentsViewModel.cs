using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using France_Vacances.Common;
using France_Vacances.Model;

namespace France_Vacances.ViewModel
{
    public class ApartmentsViewModel : DefaultViewModel
    {
        private ObservableCollection<HouseModel> _apartmentCollection;
        private HouseModel _selectedApartment;

        // Properties
        public ObservableCollection<HouseModel> ApartmentCollection
        {
            get { return _apartmentCollection; }
            set { _apartmentCollection = value; }
        }

        public HouseModel SelectedCity
        {
            get { return _selectedApartment; }
            set
            {
                _selectedApartment = value;
                OnPropertyChanged();
            }
        }

        public ApartmentsViewModel()
        {
            ApartmentCollection = new ObservableCollection<HouseModel>(HouseModel.HouseModels());
        }
    }
}
