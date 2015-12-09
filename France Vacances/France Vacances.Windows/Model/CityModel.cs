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
                new CityModel(1, "Paris", 400, "The Capitol of France", "../assets/City_splash/paris_splash.jpg","Paris, the capital (and largest) city in France is said to be one of the most visited tourist destinations not only in the country, but also in the whole Europe. The modern landscape in some parts of the city and the restored old buildings in other have made Paris great place for sightseeing and exploration, showing the evolution of the city among the years. Some of world’s most famous  museums and galleries, as well as churches and monuments can be seen there - The Louvre, The Musée d'Orsa, The Paris sewer museum, The famous Paris catacombs ,The Paris panorama, The Eiffel tower and a lot more. If you are looking for a memorable experience and a cozy atmosphere, Paris is the right place for you!"),
                new CityModel(2, "Nice", 450, "The biggest city on the French Riviera", "../assets/City_splash/nice_splash.jpg","Nice, the biggest city on the French Riviera and fifth by large in France is another preferred tourist destination. The vibran buildings and the beautiful nature and beaches of the Cote d’Azur contributes to a relaxing atmosphere and takes you away from the nowadays hectic lifestyle. Nice offers to its guests boat cruises along the Baie des Anges and Rade de Villefranche, fascinating old town, guided walking tours. We recommend Musee Matisse for people interested in beautiful oil paintings, moulding sculptures and a lot more! Nice is a memorable experience you could never forget!"),
                new CityModel(3, "Montpellier", 350, "The capital of Languedoc-Rousssillon", "../assets/City_splash/montpeiller_splash.jpg","Montpellier, the capital of Languedoc- Rousssillon, is the the 8th largest city in France. With its elegant buildings, grand hotels, and stately boulevards, it’s a quietly stylish metropolis with a hint of Barcelona about its old quarter and shady backstreets. Within the old town you will find narrow streets, wide open boulevards and busy squares. Musee Fabre, the botanical garden Jardin Des Plantes and the Montpellier zoo are some of the many places we recommend you to visit during your stay. Exceptionally beautiful is the Montpellier Planetarium."),
                new CityModel(4, "Marseilles", 370, "The second largest city in France after Paris", "../assets/City_splash/marseilles_splash.jpeg","Marseilles is the second largest city in France after Paris. As it is known to be the largest commercial port as well as a leading cruise port and freight port, Marseilles is the best place for cruises and water tours in the country. Immersing into the extraordinary atmosphere of the Mediterranean, it will provide you an unforgettable experience and the old town architecture will introduce you to the unspoiled past appearance of France. The world-wide famous cathedral Notre Dame and the Castle of If, also known as The Castle of Count Monte Cristo are two of the numeral tourist attractions worth visiting in Marseilles."),
                new CityModel(5, "Carcassonne", 290, "A fortified Frenchtown in the Aude department", "../assets/City_splash/carcassonne_splash.jpg","Carcassonne is a fortified Frenchtown in the Aude department. Here can be found interesting activities for everyone- from scrutinizing old town and citadels, through exploring shopping streets and cafes to going on a canal tours. The canal port at Carcassonne is one of the busiest, and from here you can hop on a half or whole-day canal trip, or even rent a boat for a week or two. We also recommend you to visit the museums, the cozy gardens and parks and the famous Carcassonne vineyards. . If you are looking for a memorable experience which will take you away from the strenuous everyday agenda, this is the place for you!"),
                new CityModel(6, "Versailles", 450, "Famous for the Palace of Versailles ", "../assets/City_splash/versialles_splash.jpg","Versailles is located in the western suburbs of the French capital. Being a major touristicdestination and its service-based economy have contributed to its rapid financial development, making it one of the richest cities in Paris. The Palace of Versailles, also known as The Château de Versailles, has been the scene for several historic events, which along with its beautiful architecture and design makes make it the Versailles’ most visited landmark. The gardens of the castle, The hall of mirrors and Grant Trianon Castle are also main tourist destinations. Versailles is an extraordinary experience you will never forget!"),
            };
        }
    }
}
