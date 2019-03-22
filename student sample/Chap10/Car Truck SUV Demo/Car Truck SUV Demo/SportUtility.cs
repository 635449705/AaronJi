using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Truck_SUV_Demo
{
    class SportUtility : Automobile
    {
        // Field
        private int _passengers;

        // Constructor
        public SportUtility()
        {
            _passengers = 0;
        }

        // Passengers property
        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }
    }
}
