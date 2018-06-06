using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class Weather
    {
        public int ID { get; set; }
        public string Cat { get; set; } = "Weather";
        public string Temperature { get; set; }
        public string Description { get; set; }
    }
}
