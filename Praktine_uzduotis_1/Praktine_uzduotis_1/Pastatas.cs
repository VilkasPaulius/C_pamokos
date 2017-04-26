using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis_1
{
    class Pastatas
    {
        public string Tipas { get; private set; }
        public double Kaina { get; private set; }
        public int KiekUztruksStatybos { get; private set; } //dienomis
        public int Kokybe { get; private set; } //0-10
        public int KiekReikiaDarbininku { get; private set; }
        public Darbuotojas[] Darbuotojai { get; private set; } //objektų masyvas (darbuotojų masyvas) daug darbuotojų informacijos

        public Pastatas()
        {
            //Darbuotojai = new Darbuotojas[1];
        }

        public Pastatas(string tipas, double kaina, int kiekUztruksStatybos, int kokybe, int kiekReikiaDarbininku)
        {
            Tipas = tipas;
            Kaina = kaina;
            KiekUztruksStatybos = kiekUztruksStatybos;
            Kokybe = kokybe;
            KiekReikiaDarbininku = kiekReikiaDarbininku;
            Darbuotojai = new Darbuotojas[KiekReikiaDarbininku];
            foreach (var darbuotojas in Darbuotojai)
            {
                darbuotojas.Ivedimas();
            }
        }

        public void Ivedimas()
        {
            Console.WriteLine("Pastato tipas?");
            Tipas = Console.ReadLine();

            Console.WriteLine("Statybų kaina?");
            Kaina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek užtruks statybos? (dienomis)");
            KiekUztruksStatybos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pastato kokyė? (0-10)");
            Kokybe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek reikia darbuotojų statyboms?");
            KiekReikiaDarbininku = Convert.ToInt32(Console.ReadLine());

            Darbuotojai = new Darbuotojas[KiekReikiaDarbininku];
            for (int i = 0; i < KiekReikiaDarbininku; i++)
            {
                Darbuotojai[i] = new Darbuotojas(); //sukonstruojam tuščią darbuotojo objektą 
                Darbuotojai[i].Ivedimas(); // sukurtam objektui duomenis
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pastato tipas: "+Tipas);
            Console.WriteLine("Statybų kaina: "+Kaina+" €");
            Console.WriteLine("Statybos užtruks {0} dienų",KiekUztruksStatybos);
            Console.WriteLine("Šio pastato kokybė {0}/10",Kokybe);
            Console.WriteLine("Kiek reikia darbuotojų statyboms: "+KiekReikiaDarbininku);

            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Parodyti darbuotojus? (t/n)");
            var veiksmas = Console.ReadLine();
            if (veiksmas == "t")
            {
                foreach(var darbuotojas in Darbuotojai)
                {
                    darbuotojas.Isvedimas();
                }
            }
        }

        public void NaujaKainaPoAlgu()
        {
            var visosAlgos = 0.0;
            foreach(var d in Darbuotojai)
            {
                visosAlgos += d.Alga;
            }
            Kaina += visosAlgos;
        }

    }
}
