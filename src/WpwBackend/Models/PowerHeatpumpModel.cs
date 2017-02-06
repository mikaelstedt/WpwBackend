using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpwBackend.Models
{
    public class PowerHeatpumpModel
    {
        public string Name { get; set; }
        public string Corporation { get; set; }
        public int FlowTemp { get; set; }
        public int Brine { get; set; }
        public double PowerOutput { get; set; }
        public double InputPower { get; set; }
        public bool IntegratedWaterHeater { get; set; }
    }
}
