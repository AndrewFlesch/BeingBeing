using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class Social
    {
        public int ID { get; set; }
        public string What { get; set; }
        public string Where { get; set; }
        public int Duration { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
    }
}
