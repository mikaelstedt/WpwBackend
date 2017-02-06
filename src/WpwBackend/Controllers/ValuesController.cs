using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WpwBackend.Models;

namespace WpwBackend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static LocationModel[] locationModel = new[]
{
            new LocationModel { City="Täby",        DegreeDays=3344, Dut=-17,   Area="C",  AverageTemperature=6.6 },
            new LocationModel { City="Stockholm",   DegreeDays=3346, Dut=-17,   Area="C",  AverageTemperature=6.6 },
            new LocationModel { City="Tranås",      DegreeDays=3876, Dut=-18,   Area="C",  AverageTemperature=6.2 },
            new LocationModel { City="Boden",       DegreeDays=5497, Dut=-30,   Area="A" , AverageTemperature=1.3 },
        };

        private static PowerHeatpumpModel[] powerHeatpumpModels = new[]
        {
            new PowerHeatpumpModel {Name="F1255", Corporation="Nibe", FlowTemp=35, Brine=0, PowerOutput=3.08, InputPower=1.34, IntegratedWaterHeater=true },
            new PowerHeatpumpModel {Name="F1155", Corporation="Nibe", FlowTemp=35, Brine=0, PowerOutput=3.08, InputPower=1.34, IntegratedWaterHeater=false },
        };        
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("[action]")]
        public LocationModel[] GetLocationModels(string value)
        {
            return locationModel;
        }

        [HttpPost("[action]")]
        public PowerHeatpumpModel[] GetHeatpumpModels()
        {
            return powerHeatpumpModels;
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


}
