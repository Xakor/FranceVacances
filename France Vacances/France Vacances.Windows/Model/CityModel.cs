using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Model
{
    public class CityModel
    {
        // Created Frank Branch

        // Instance Field
        private int _cityId;
        private string _cityName;
        private double _basePrice;
        private string _tagline;
        private string _imgPath;
        private string _bigDescription;

        // Set up properties
        public int CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }
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
        public string BigDescription
        {
            get { return _bigDescription; }
            set { _bigDescription = value; }
        }

        public override string ToString()
        {
            return CityName.ToString();
        }

        //Constructor
        public CityModel(int cityId, string name, double minPrice, string tagline, string imgPath, string bigDescription)
        {
            this._cityId = cityId;
            this._cityName = name;
            this._basePrice = minPrice;
            this._tagline = tagline;
            this._imgPath = imgPath;
            this._bigDescription = bigDescription;
        }

        public static CityModel[] CityModels()
        {
            return new[]
            {
                new CityModel(1, "Paris", 400, "The Capitol of France", "../assets/City_splash/paris_splash.jpg","big description for Paris here"),
                new CityModel(2, "Nice", 450, "something, something", "../assets/City_splash/nice_splash.jpg","big description for Nice here"),
                new CityModel(3, "Montpellier", 350, "Ubisoft have their headquarter there", "../assets/City_splash/montpeiller_splash.jpg","big description for Montpillier here"),
                new CityModel(4, "Marseilles", 370, "We Surrender!", "../assets/City_splash/marseilles_splash.jpeg","big description for Marseilles here"),
                new CityModel(5, "Carcassonne", 290, "Castles and board games", "../assets/City_splash/carcassonne_splash.jpg","big description for Carcassonne here"),
                new CityModel(6, "Versailles", 450, "You know you like it", "../assets/City_splash/versialles_splash.jpg","big description for Versailles here"),
            };
        }
    }
}
