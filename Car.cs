using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol
{
    public class Car : Vehicle
    {
        private int _noOfPersons;

        public Car(string licensePlateNo, int noOfPersons) : base(licensePlateNo)
        {
            _noOfPersons = noOfPersons;
        }

        public int NoOfPersons
        {
            get { return _noOfPersons; }
        }
    }
}
