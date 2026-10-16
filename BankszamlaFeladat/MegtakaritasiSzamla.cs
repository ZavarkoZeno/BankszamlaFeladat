using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BankszamlaFeladat
{
    public class MegtakaritasiSzamla : Bankszamla
    {
        public MegtakaritasiSzamla(string tulajdonos, string szamlaszam, decimal kezdoEgyenleg = 0) : base(tulajdonos, szamlaszam, kezdoEgyenleg)
        {

        }

        public override void Kifizetes(decimal osszeg)
        {
            if (osszeg <= 0)
            {
                throw new ArgumentException("A kifizetés összege nem lehet negatív");
            }
            if (Egyenleg - osszeg < 0)
            {
                throw new InvalidOperationException("Sikertelen kifizetés");
            }

            Egyenleg -= osszeg;
        }
    }
}
