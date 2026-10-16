using System;
using System.Collections.Generic;
using System.Text;

namespace BankszamlaFeladat
{
    public abstract class Bankszamla
    {
        public string Tulajdonos { get; set; }
        public decimal Egyenleg { get; protected set; }
        public string Szamlaszam { get; set; }

        public Bankszamla(string tulajdonos, string szamlaszam, decimal kezdoEgyenleg)
        {
            if (string.IsNullOrWhiteSpace(tulajdonos))
            {
                throw new ArgumentException("A tulajdonos neve nem lehet üres");
            }
            if (string.IsNullOrWhiteSpace(szamlaszam))
            {
                throw new ArgumentException("A számlaszám nem lehet üres");
            }
            if (kezdoEgyenleg < 0)
            {
                throw new ArgumentException("A kezdő egyenleg nem lehet negatív");
            }

            Tulajdonos = tulajdonos;
            Szamlaszam = szamlaszam;
            Egyenleg = kezdoEgyenleg;
        }

        public void Befizetes(decimal osszeg)
        {
            if (osszeg <= 0)
            {
                throw new ArgumentException("A befizetés összege nem lehet negatív");
            }
            Egyenleg += osszeg;
        }

        public abstract void Kifizetes(decimal osszeg);
    }
}
