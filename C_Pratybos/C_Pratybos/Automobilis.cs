using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pratybos
{
    class Automobilis
    {
        public string Marke;
        public int Metai;
        public string Spalva;
        public int Galia;
        public int RatuDydis;
        public string KuroTipas;
        //private int _skaicius;  <-- private kintamasis rasomas su pabraukimu

        public Automobilis() { } //tuscias konstruktorius reikalingas jei yra nors kartą panaudotas

        public Automobilis(string marke, int metai, string spalva, int galia, int ratudydis, string kurotipas)
        {
            //Konstruktorius, kuris iš karto gali kažka priskirti
            //this.Marke = Marke;
            Marke = marke; //Objekto elementui suteikiam reikšmę
            Metai = metai;
            Spalva = spalva;
            Galia = galia;
            RatuDydis = ratudydis;
            KuroTipas = kurotipas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Marke " + Marke);
            Console.WriteLine("Metai " + Metai);
            Console.WriteLine("Spalva " + Spalva);
            Console.WriteLine("Galia " + Galia + " kw");
            Console.WriteLine("Ratų dydis " + RatuDydis + " coliu");
            Console.WriteLine("Kuro tipas " + KuroTipas);
            Console.WriteLine("Automobiliui yra " + KiekMetuAutomobiliui() + " metu"); //metode naudojam metoda
            Console.WriteLine("______________________________");
        }

        public int KiekMetuAutomobiliui()
        {
            return 2017 - Metai;
        }
    }
}
