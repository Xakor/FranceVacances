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
        public HouseModel(int aptId, int aptInCity, string aptAddress, string aptInfo, double aptPrice, string aptImgPath)
        {
            this._aptId = aptId;
            this._aptInCity = aptInCity;
            this._aptAddress = aptAddress;
            this._aptInfo = aptInfo;
            this._aptPrice = AptPrice;
            this._aptImgPath = aptAddress;
        }
    }
}
