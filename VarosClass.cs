using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosokDogaFintaL
{
    internal class VarosClass
    {
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public double Nepesseg { get; set; }

        public VarosClass(string s) 
        {
            var v=s.Split(';');
            Varos = v[0];
            Orszag = v[1];
            Nepesseg = Math.Round(double.Parse(v[2]),2);
        }
        public override string ToString()
        {
            return $"{Varos} {Orszag} {Nepesseg}";
        }
    }
}
