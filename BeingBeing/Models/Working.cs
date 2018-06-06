using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class Working
    {
        public int ID { get; set; }
        public string Cat { get; set; } = "Working";
        public string Type { get; set; }
        public int Duration { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
    }
}
