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
        public ObservableCollection<HouseModel> ApartmentCollection { get; set; }
        

    }
}
