using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Model
{
    public class CityModel
    {
        // Instance Field
        private string _cityName;
        private double _basePrice;
        private string _tagline;
        private string _imgPath;

        // Set up properties
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        public double BasePrice
        {
            get { return _basePrice; }
            set { _basePrice = value; }
        }
        public string Tagline
        {
            get { return _tagline; }
            set { _tagline = value; }
        }
        public string ImgPath
        {
            get { return _imgPath; }
            set { _imgPath = value; }
        }
        

        public override string ToString()
        {
            return CityName.ToString();
        }

        //Constructor
        public CityModel(string name, double minPrice, string tagline, string imgPath)
        {
            this._cityName = name;
            this._basePrice = minPrice;
            this._tagline = tagline;
            this._imgPath = imgPath;
        }

        public static CityModel[] CityModels()
        {
            return new[]
            {
                new CityModel("Paris", 400, "The Capitol of France", "../assets/france_faded.png"),
                new CityModel("Nice", 450, "something, something", "../assets/france_faded.png"),
                new CityModel("Montpillier", 350, "Ubisoft have their headquarter there", "../assets/france_faded.png"),
                new CityModel("Le Mans", 370, "Wroom wroom, boom boom", "../assets/france_faded.png"),
                new CityModel("Carcassonne", 290, "Castles and board games", "../assets/france_faded.png"),
                new CityModel("Versailles", 450, "You know you like it", "../assets/france_faded.png"),
            };
        }
    }
}
