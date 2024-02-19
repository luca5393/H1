using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningespil2
{
    internal class Terning
    {
        public int Sides {  get; set; }
        public Terning() 
        { 
            Sides = 6;
        }
        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, Sides+1);
        }
    }
}
