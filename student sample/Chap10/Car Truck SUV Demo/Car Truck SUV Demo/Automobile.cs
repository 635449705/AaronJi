using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Truck_SUV_Demo
{
    class Automobile
    {
        // Fields
        private string _make;
        private string _model;
        private int _mileage;
        private decimal _price;

        // Constructor
        public Automobile()
        {
            _make = "";
            _model = "";
            _mileage = 0;
            _price = 0;
        }

        // Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // Mileage property
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        // Price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
