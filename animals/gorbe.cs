using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class gorbe : heivon_asli
    {
        public gorbe(string noee, string esm, string keshvar) : base(noee, esm, keshvar) 
        { 
        }
        public override void seda()
        {
            Console.WriteLine($"{esm} ye gorbas ke mige mewwwww");
        }
    }
}
