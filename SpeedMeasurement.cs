using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol
{
    public class SpeedMeasurement
    {
        private static int idCounter = 1;

        private DateTime _timeStamp;
        private int _speed;
        private int _id;

        public SpeedMeasurement(int speed)
        {
            _speed = speed;
            _timeStamp = DateTime.Now;
            _id = idCounter;

            idCounter++;
        }

        public int Speed
        {
            get { return _speed; }
        }

        public int Id
        {
            get { return _id; }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp;  }
        }

        public override string ToString()
        {
            return "ID: " + _id + ", Timestamp: " + _timeStamp + ", Speed: " + _speed;
        }
    }
}
