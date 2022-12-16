using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;
        protected short hodinovaMzda;
        protected int HodinovaMzda
        {   get
            {
                return hodinovaMzda;
            }  
        }
        public int odpracHodiny = 0;
        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, short hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
        }

        public int PocetDni()
        {
            TimeSpan odNastupu = DateTime.Now - datumNastupu;
            int pocetdni;
            pocetdni = Convert.ToInt32(odNastupu.TotalDays);
            return pocetdni;
        }
        public int OdpracujHodiny(short hodiny)
        {
            return odpracHodiny += hodiny;
        }
        public virtual int VypoctiMzdu()
        {
            int vysledek = odpracHodiny * HodinovaMzda;
            return vysledek;
        }
        public string Vypis()
        {
            return "Jméno: " + jmeno + "\nPříjmení: " + prijmeni + "\nDatum nástupu: " + datumNastupu + "\nHodinová mzda: " + HodinovaMzda + "\nPočet dní v práci: " + PocetDni() + "\nMzda: " + VypoctiMzdu();
        }
    }
}
