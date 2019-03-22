using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Truck_SUV_Demo
{
    class Car : Automobile
    {
        // Field
        private int _doors;

        // Constructor
        public Car()
        {
            _doors = 0;
        }

        // Doors property
        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }
    }
}
