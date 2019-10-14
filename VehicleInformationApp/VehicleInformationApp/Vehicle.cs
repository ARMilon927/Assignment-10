using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInformationApp
{
    class Vehicle
    {
        public string VehicleName { get; set; }
        public string RegNo { get; set; }
        public List<double> Speeds { get; set; }

        public Vehicle()
        {
            Speeds = new List<double>();
        }

        public double GetMinSpeed()
        {
            return Speeds.Min();
        }
        public double GetMaxSpeed()
        {
            return Speeds.Max();
        }
        public double GetAvgSpeed()
        {
            return Speeds.Average();
        }
    }
}
