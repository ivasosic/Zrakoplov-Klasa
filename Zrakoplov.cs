using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZrakoplovKlasa
{
    internal class Zrakoplov
    {
        string naziv;
        int dosegleta, brzina;
        double snagamotora;

        TOCKA T1 = new TOCKA();
        TOCKA T2 = new TOCKA();

        public string Naziv1 { get => naziv; set => naziv = value; }
        public double SnagaMotora1 { get => snagamotora; set => snagamotora = value; }
        public int DosegLeta1 { get => dosegleta; set => dosegleta = value; }
        public int Brzina { get => brzina; set => brzina = value; }

        public Zrakoplov(String naziv, double snagamotora, int dosegleta, int x, int y)
        {
            this.naziv = naziv;
            this.snagamotora = snagamotora;
            this.dosegleta = dosegleta;
            this.brzina = (int)(snagamotora * 0.4);
            T2 = new TOCKA(x,y);
        }


        public double pozicija()
        {
            double poz = (T1.udaljenost(T2))/brzina;
            return poz;

        }

            public Zrakoplov() 
        { 
            
        }


        public override string ToString()
        {
            string ispis = "Naziv: " + this.naziv + "\n"
                + "Snaga motora: " + this.snagamotora + " kW\n"
                + "Doseg leta: " + this.dosegleta + " km\n" + "Brzina: " + this.brzina + " kmh\n" + "Trajanje leta: "+pozicija();
            return ispis;
        }
    }
}
