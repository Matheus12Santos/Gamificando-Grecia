﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Models
{
    internal class Medidor
    {
        public int percentage { get; set; }
        public string image { get; set; }
        public int name { get; set; }
        public int maxValue { get; set; }
        public int minValue { get; set; }
        public int actualValue { get; set; }
    }
}
