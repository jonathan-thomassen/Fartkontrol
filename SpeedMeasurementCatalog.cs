using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol
{
    public class SpeedMeasurementCatalog
    {
        private List<SpeedMeasurement> _speedMeasurements;
        private string _address;
        private string _zone;
        private int _speedLimit;

        public SpeedMeasurementCatalog(string address, string zone, int speedLimit)
        {
            _speedMeasurements = new List<SpeedMeasurement>();

            _address = address;
            _zone = zone;
            _speedLimit = speedLimit;
        }

        public string Address
        {
            get { return _address; }
        }
        public string Zone
        {
            get { return _zone; }
        }
        public int SpeedLimit
        {
            get { return _speedLimit; }
        }

        public void AddSpeedMeasurement(int speed)
        { 
            if (speed > 300 || speed <= 0)
                throw new System.ArgumentException("The speed is invalid.");

            _speedMeasurements.Add(new SpeedMeasurement(speed));
        }

        public double AverageSpeed()
        {
            int i = 0;
            int totalSpeed = 0;

            foreach (SpeedMeasurement speedMeasurement in _speedMeasurements)
            {
                totalSpeed += speedMeasurement.Speed;
                i++;
            }

            if (i == 0)
                return 0.0;

            return (double) totalSpeed / (double) i;
        }

        public int NoOfOverSpeedLimit()
        {
            int i = 0;

            foreach (SpeedMeasurement speedMeasurement in _speedMeasurements)
            {
                if (speedMeasurement.Speed > SpeedLimit)
                    i++;
            }

            return i;
        }

        public int NoOfCutInLicense()
        {
            int cuts = 0;

            for (int i = 0; i < _speedMeasurements.Count; i++)
            {
                if (_speedMeasurements[i].Speed >= (double) SpeedLimit * 1.3)
                    cuts++;
            }

            return cuts;
        }

        public int NoOfConditionalRevocations()
        {
            int i = 0;

            foreach (SpeedMeasurement speedMeasurement in _speedMeasurements)
            {
                if (SpeedLimit == 130)
                {
                    if (speedMeasurement.Speed >= 1.30 * (double) SpeedLimit)
                        i++;
                }
                else
                {
                    if (speedMeasurement.Speed >= 1.60 * (double) SpeedLimit)
                        i++;
                }
            }

            return i;
        }

        public int NoOfUnconditionalRevocations()
        {
            int i = 0;

            foreach (SpeedMeasurement speedMeasurement in _speedMeasurements)
            {
                if (speedMeasurement.Speed >= 100)
                {
                    if (speedMeasurement.Speed >= 2 * SpeedLimit)
                        i++;
                }
            }

            return i;
        }

        public override string ToString()
        {
            string returnString = "";

            returnString += "Address: " + Address;
            returnString += ", Zone: " + Zone;
            returnString += ", Speed limit: " + SpeedLimit + "\n";

            foreach (SpeedMeasurement speedMeasurement in _speedMeasurements)
            {
                returnString += speedMeasurement.ToString() + "\n";
            }

            return returnString;
        }
    }
}
