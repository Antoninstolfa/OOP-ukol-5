using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Vedouci : Zamestnanec
    {
        private int priplatekZaVedeni;
        private string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, short hodinovaMzda, int priplatekZaVedeni, string titul) : base(jmeno, prijmeni, datumNastupu, hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;
        }

        public override int VypoctiMzdu()
        {
            int vysledek = odpracHodiny * HodinovaMzda;
            return vysledek;
        }
    }
}
