using System;

namespace Fartkontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedMeasurementCatalog smc1 = new SpeedMeasurementCatalog("Sønderby Bro 40, 4050", "By", 50);

            try
            {
                smc1.AddSpeedMeasurement(61);
                smc1.AddSpeedMeasurement(45);
                smc1.AddSpeedMeasurement(52);
                smc1.AddSpeedMeasurement(70);
                smc1.AddSpeedMeasurement(300);
                smc1.AddSpeedMeasurement(1000);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("One or more of the speed parameters is invalid, it has been ignored.\n");
            }

            Console.WriteLine(smc1);
            Console.WriteLine("Average speed: " + smc1.AverageSpeed().ToString("0.00") + " km/h");

            Console.WriteLine("# over speed limit: " + smc1.NoOfOverSpeedLimit());
            Console.WriteLine("# of cuts in licenses: " + smc1.NoOfCutInLicense());
            Console.WriteLine("# of conditional revocations: " + smc1.NoOfConditionalRevocations());
            Console.WriteLine("# of unconditional revocations: " + smc1.NoOfUnconditionalRevocations());
        }
    }
}
