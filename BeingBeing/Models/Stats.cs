using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class Stats
    {
        public string OwnerID { get; set; }
        public int ID { get; set; }
        public string Cat { get; set; } = "Stats";
        public int Height { get; set; }
        public int Weight { get; set; }
        public int BodyFat { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int LDL { get; set; }
        public int HDL { get; set; }
        public int VLDL { get; set; }
        public int Waist { get; set; }
        public int Chest { get; set; }
        public int Arms { get; set; }
        public int Legs { get; set; }
        public DateTime DateState { get; set; }
        public string Notes { get; set; }
    }
}
