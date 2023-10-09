using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class sag : heivon_asli
    {
        public sag( string noee, string esm, string keshvar) : base(noee, esm, keshvar) 
        { 
        }
        public override void seda()
        {
            Console.WriteLine($"{esm} ye sage ke mige hap happppp");
        }
    }
    
}
