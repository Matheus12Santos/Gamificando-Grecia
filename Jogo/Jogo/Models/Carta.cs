﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Models
{
    internal class Carta
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Option { get; set; }
    }
}
