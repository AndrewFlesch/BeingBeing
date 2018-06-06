﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Models
{
    public class EmotionalStates
    {
        public int ID { get; set; }
        public string Cat { get; set; } = "Mood";
        public string Type { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
        public string Location { get; set; }
    }
}

