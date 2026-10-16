using System;
using System.Collections.Generic;
using System.Text;

namespace BankszamlaFeladat
{
    public class Folyoszamla : Bankszamla
    {
        public decimal Hitelkeret { get; set; }

        public Folyoszamla(string tulajdonos, string szamlaszam, decimal kezdoEgyenleg, decimal hitelkeret) : base(tulajdonos, szamlaszam, kezdoEgyenleg)
        {
            if (hitelkeret < 0)
            {
                throw new ArgumentException("A hitelkeret nem lehet negatív");
            }
            Hitelkeret = hitelkeret;
        }
        
        public override void Kifizetes(decimal osszeg)
        {
            if (osszeg <= 0)
            {
                throw new ArgumentException("A kifizetés összege nem lehet negatív");
            }
            if (Egyenleg - osszeg < -Hitelkeret)
            {
                throw new InvalidOperationException("Sikertelen kifizetés");
            }
            Egyenleg -= osszeg;
        }
    }
}
