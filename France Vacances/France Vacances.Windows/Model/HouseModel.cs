using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Model
{

    public class HouseModel
    {
        //Instance Field
        private int _aptId;
        private int _aptInCity;
        private string _aptAddress;
        private string _aptInfo;
        private double _aptPrice;
        private string _aptImgPath;

        //Properties
        public int AptId
        {
            get { return _aptId; }
            set { _aptId = value; }
        }
        public int AptInCity
        {
            get { return _aptInCity; }
            set { _aptInCity = value; }
        }
        public string AptAddress
        {
            get { return _aptAddress; }
            set { _aptAddress = value; }
        }
        public string AptInfo
        {
            get { return _aptInfo; }
            set { _aptInfo = value; }
        }
        public double AptPrice
        {
            get { return _aptPrice; }
            set { _aptPrice = value; }
        }

        public string AptImgPath
        {
            get { return _aptImgPath; }
            set { _aptImgPath = value; }
        }

        //Constructor
        public HouseModel(int aptId, int aptInCity, string aptAddress, string aptInfo, double aptPrice, string imgPath)
        {
            this._aptId = aptId;
            this._aptInCity = aptInCity;
            this._aptAddress = aptAddress;
            this._aptInfo = aptInfo;
            this._aptPrice = aptPrice;
            this._aptImgPath = imgPath;
        }

        public static HouseModel[] HouseModels()
        {
            return new HouseModel[]
            {
                new HouseModel(1, 1, "Le Wagram-Champs-Elysées", "Located 800 metres from the Arc the Triomphe and the Champs Elysées Avenue, Le Wagram-Champs-Elysées is 600 metres from the Monceau Park and 170 metres from Ternes Metro Station. It provides free Wi-Fi access and self-catering accommodation. The apartments have a fully equipped kitchen with dishwasher, Nespresso coffee machine and oven. The living room is provided with LCD TV, DVD player and a sofa bed. One of the accommodations also includes a balcony and air conditioning.", 700, "../Assets/Apartments/parisapt1.jpg"),
                new HouseModel(2, 1, "Les Appartments du Louvre" ,"Les Appartements du Louvre is a group of apartments situated in various locations around the Louvre, within a 15-minute walk from Georges Pompidou Centre and Les Halles Shopping Centre. Guests enjoy contemporary-style accommodations with free Wi-Fi access and a flat-screen and satellite TV. The heated apartment at Les Appartements du Louvre features parquet flooring. The bathroom includes a hairdryer. The kitchenette on site provides a coffee machine, a toaster and an electric kettle. All type of restaurants and bars can be found within walking distance. The accommodations are 190 metres from Sentier Metro Station which provides direct access to Opéra Garnier or Place de la République. This is a great choice for travellers interested in architecture, history and museums. This area is also great for shopping, with popular brands nearby: H & M, Zara.", 470, "../Assets/Apartments/parisapt2.jpg"), 
                new HouseModel(3, 2, "Appartment du Palais", "Appartement du Palais is a one-bedroom apartment located in Nice, 200 metres from Cours Saleya and a 15-minute walk from Notre-Damedu Port. This design-style apartment offers a flat-screen TV, an equipped kitchen and free Wi-Fi access is available. The apartment will provide you with air conditioning and a seating area. Featuring a multi-jet shower, private bathroom also comes with a hairdryer and towels. There is an equipped, open-plan kitchen with a dishwasher and a microwave. Restaurants and bars can be found right at the bottom of the property. The accommodation is situated 1.5 km from Nice Train Station and 7 km from Nice Côte d’Azur Airport. The property offers parking at an extra cost.", 450, "../Assets/Apartments/niceapt1.jpg"),
                new HouseModel(4, 2, "Un Jardin à la Plage", "Featuring a furnished terrace and a garden with sun beds, Un Jardin à la Plage offers self-catering accommodation in Nice. The property is 100 metres from the beach and the Promenade des Anglais. Free WiFi access is available. This air-conditioned apartment features views of the garden, a seating area and 3 flat-screen TVs. There is a full kitchen with a dishwasher and a bathroom with a bathtub, shower, free toiletries and a hairdryer. Un Jardin à la Plage also offers barbecue facilities. Restaurants, bars and shops can be found in the immediate area. The property is 100 metres from Nice Museum of Fine Arts, 1.5 km from Rue Massena Pedestrian Street and 2 km from Promenade du Paillon Park. Nice-Ville Train Station is 2 km away and Nice Côte d'Azur Airport is located 5.5 km away.", 800, "../Assets/Apartments/niceapt2.jpg"), 
                new HouseModel(5, 3, "Vichy Spa Hotel Montpellier Juvignac", "Offering an outdoor and an indoor pool, Vichy Spa Hotel Montpellier Juvignac is located in Juvignac on the Fontcaude Golf Course, just 2 km from central Montpellier. It offers a large spa centre, free WiFi internet access and a garden. Guest rooms and suites at Vichy Spa Hotel Montpellier Juvignac are air-conditioned and include a flat-screen TV with cable channels. They each have a private bathroom with a hairdryer, toiletries and a bath or shower. The on-site restaurant “Au comptoir de Fontcaude, bistrot by J&L Pourcel’’ proposes traditional Mediterranean cuisine, and breakfast is served every morning at the hotel.Guests have the option of enjoying breakfast in the comfort of their rooms. There is a 2600 m² spa dedicated to well being and health prevention with hydrotherapy treatments, world massages, esthetic cares. It also offers a heated pool, sauna, steam bath and fitness center. The hotel is 7 km from Euromédecine and Hôpitaux-Facultés districts and is 18 km from Montpellier – Méditerranée Airport. Montpellier Saint Roch Train Station is a 20-minute drive away. Free secured parking is available on site. ", 400, "../Assets/Apartments/montpeillerapt1.jpg"), 
                new HouseModel(6, 3, "Colombet - Neocity", "Colombet - Neocity offers accommodation in Montpellier, 2.1 km from Zenith Sud Montpellier. The unit is 3.9 km from Stade Yves-du-Manoir. Private parking is available on site. There is a seating area and a kitchen. A TV is available. Colombet - Neocity features free WiFi throughout the property. The Corum is 1.3 km from Colombet - Neocity, while Fabre Museum is 1.3 km from the property. The nearest airport is Mediterranee Airport, 6 km from the property.", 300, "../Assets/Apartments/montpeillerapt2.jpg"), 
                new HouseModel(7, 4, "Rue Félix Fregier", "Cozy 2 bedroom family apartment at Rue Félix Fregier, Marseille, located only 20 minutes drive away fromMarseille Provence Airport. The apartment is a short walking distance from the coast, and a short distance away from several attractions. There is a living space with TV, a kitchen and free Wi-Fi available. There is a private parking spot available.", 350, "../Assets/Apartments/marseilleapt1.jpg"), 
                new HouseModel(8, 4, "Avenue de Odessa", "1 bedroom dublex on the beach in the heart of Pointe Rouge. Tv, kitchen, air conditioning, washing machine and free Wi-Fi are available. Free public parking just above the beach. Situated 7 km south of the Old Port and 4 km from the town of Gouda. Different restaurants on the beach, cafés, bakeries are all located within walking distance.", 400, "../Assets/Apartments/marseilleapt2.jpg"),
                new HouseModel(9, 5, "Rue Prosper Montagne", "1 bedroom loft-type apartment. Located in a quiet street, close to the Canal du Midi and the train station. 10 minutes walk to reach the medieval city. Within 100 meters of supermarkets, shops, cinema, restaurants, bike rentals and boat trip on the Canal du Midi. Kitchen and Free Wi-Fi is available.", 350, "../Assets/Apartments/carcassonneapt1.jpg"),
                new HouseModel(10, 5, "Rue Trivalle", "2 bedroom apartment located at the foot of the city. Walking distance from the Bastide. The apartment is fully quipped to accomodate 4 people. TV, stereo, Wi-Fi, washing machine and dryer are available. ", 200, "../Assets/Apartments/carcassonneapt2.jpg"),
                new HouseModel(11, 6, "Rue d'Anjou", "2 bedroom apartment, located 10 minutes walk away from the Chateau de Versailles and 5 minutes walk from the station Chateau de Versailles. Located in the St. Louis area, with lots of local shops nearby. Kitchen, TV and free Wi-Fi is available.", 300, "../Assets/Apartments/versaillesapt1.jpg"),
                new HouseModel(12, 6, "Rue de l'Occident", "1 bedroom apartment located in the St. Louis area, 10 minutes walk from public transportation and castle. 30 minutes from the Eiffel Tower and Musée d'Orsay. 40 minutes from the Notre Dame and the center of paris (direct train) The apartment is located on the ground floor and has a small private garden courtyard. It has three rooms, a kitchen and a bathroom. Free Wi-Fi and TV are available.", 500, "../Assets/Apartments/versaillesapt2.jpg"),
            };
        }
    }
}