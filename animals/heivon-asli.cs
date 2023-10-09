using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    public abstract class heivon_asli
    {
        public string noee { get; }
        public string esm { get; }
        public string keshvar { get; }
        public heivon_asli(string noee, string ems, string keshvar)
        {
            this.noee = noee;
            this.esm = ems;
            this.keshvar = keshvar;
        }
        public heivon_asli(string noee, string ems)
        {
            this.noee = noee;
            this.esm = ems;
        }

        public abstract void seda();
    }
}
