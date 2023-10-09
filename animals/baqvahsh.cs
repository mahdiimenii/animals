using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    internal class baqvahsh
    {
        private List<heivon_asli> h1;
        public baqvahsh()
        {
            h1= new List<heivon_asli>();
        }
        public void ezafekardan (heivon_asli h)
        {
            h1.Add(h);
        }
        public void neshondadan()
        {
            Console.WriteLine("heyvonaye baqvahsh:");
            foreach (heivon_asli h1 in h1)
            {
                Console.WriteLine($"esm: {h1.esm}, noee: {h1.noee}, keshvar: {h1.keshvar}");
                h1.seda();
                Console.WriteLine(".........................");
            }
        }
    }
}
