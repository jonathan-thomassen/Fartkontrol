using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol
{
    public class Truck : Vehicle
    {
        private int _maxLoad;

        public Truck(string licensePlateNo, int maxLoad) : base(licensePlateNo)
        {
            _maxLoad = maxLoad;
        }

        public int MaxLoad
        {
            get { return _maxLoad; }
        }
    }
}
