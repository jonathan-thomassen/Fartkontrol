using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol
{
    public class Vehicle
    {
        private string _licensePlateNo;

        public Vehicle(string licensePlateNo)
        {
            _licensePlateNo = licensePlateNo;
        }

        public string LicensePlateNo
        {
            get { return _licensePlateNo; }
        }
    }
}
