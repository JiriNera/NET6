using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Model
{
    public class Cars

    {
        public Cars(string znacka, string barva, string spz, double km)
        {
            Znacka = znacka;
            Barva = barva;
            SPZ = spz;
            KM = km;
        }

        public Cars()
        {
            
        }


        public string Znacka { get; set; }

        public string Barva { get; set; }

        public string SPZ { get; set; }

        public double KM { get; set; }

        public void AddKM(double km)
        {
            KM += km;
        }

        public void ResetKM(double rkm)
        {
            KM = 0;
        }

        public override string ToString()
        {
            return $"Registracni znacka: {SPZ} Barva auta: {Barva}";
        }
    }
}
