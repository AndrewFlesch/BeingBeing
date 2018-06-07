using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class Sleep
    {
        public int ID { get; set; }
        public string Cat { get; set; } = "Sleep";
        public string Type { get; set; }
        public DateTime WentDown { get; set; }
        public DateTime WokeUp { get; set; }
        public string Notes { get; set; }
        public int Duration { get; set; }
    }
}
