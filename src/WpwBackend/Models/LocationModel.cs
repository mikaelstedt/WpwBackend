using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpwBackend.Models
{
    public class LocationModel
    {
        public string City { get; set; }
        public double DegreeDays { get; set; }
        public double Dut { get; set; }
        public string Area { get; set; }
        public double AverageTemperature { get; set; }
    }
}
