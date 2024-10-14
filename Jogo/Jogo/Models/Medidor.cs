using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Models
{
    internal class Medidor
    {
        public int Percentage { get; set; }
        public string Image { get; set; }
        public int Name { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int ActualValue { get; set; }
    }
}
