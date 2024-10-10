using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Models
{
    internal class Carta
    {
        public int id { get; set; }
        public int name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int option { get; set; }
    }
}
