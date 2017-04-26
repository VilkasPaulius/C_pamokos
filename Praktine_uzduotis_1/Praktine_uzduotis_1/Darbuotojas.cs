using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis_1
{
    class Darbuotojas
    {
        public string VardasPavarde { get; private set; } //su set ir get apribojam skaitymą keitimą
        public string Specialybe { get; private set; }
        public bool ArGeria { get; private set; }
        public double Etatas { get; private set; } //0-1
        public int Patirtis { get; private set; } //metais
        public double Alga { get; private set; }

        //ctor -tab
        public Darbuotojas() { }

        public Darbuotojas(string vardasPav, string specialybe, bool arGeria, double etatas, int patirtis, double alga)
        {
            VardasPavarde = vardasPav;
            Specialybe = specialybe;
            ArGeria = arGeria;
            Etatas = etatas;
            Patirtis = patirtis;
            Alga = alga;

        }

        public void Isvedimas()
        {
            Console.WriteLine("Darbuotojo {0} duomenys:", VardasPavarde);
            Console.WriteLine("Atstovaujamos pareigos {0}.", Specialybe);
            Console.WriteLine(ArGeria ? "Šis darbuotojas laka" : "Čia ne statybininkas");
            // inline if:
            // sąlyga ? kodas jei tiesa : kodas jei netiesa
            Console.WriteLine("Darbuotojas dirba {0} etatu, per mėnesį uždirba {1} €", Etatas, Alga);
            Console.WriteLine("Dirba jau {0} metų.", Patirtis);
            Console.WriteLine("____________________________________________________________");
        }

        public void Ivedimas()
        {
            Console.WriteLine("Įveskite vardą ir pavardę");
            VardasPavarde = Console.ReadLine();
            Console.WriteLine("Kokia specialybė?");
            Specialybe = Console.ReadLine();
            Console.WriteLine("Ar darbuotojas mėgsta išgerti? (true/false)");
            ArGeria = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Kokiu etatu dirba? 0-1");
            Etatas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darbo patirtis metais?");
            Patirtis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gaunama alga €?");
            Alga = Convert.ToDouble(Console.ReadLine());

        }
    }
}
