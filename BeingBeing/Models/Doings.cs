using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class Doings
    {
        public int ID { get; set; }
        public string Doing { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
        public string Weather { get; set; }
        public int Temperature { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
