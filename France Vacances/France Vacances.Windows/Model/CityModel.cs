using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Model
{
    class CityModel
    {
        private string _name;
        private double _minPrice;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double MinPrice
        {
            get { return _minPrice; }
            set { _minPrice = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public CityModel(string name, double minPrice)
        {
            this._name = name;
            this._minPrice = minPrice;
        }
    }
}
