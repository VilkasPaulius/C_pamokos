using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pratybos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar dangus yra giedras?");
            var oras = Convert.ToInt32(Console.ReadLine());
            rezultatas(oras);
        }
        public static void rezultatas(int reiksme)
        {
            Console.WriteLine("Įvesta reikšmė {0}.",reiksme);
            if (reiksme == 0)
            {
                Console.WriteLine("Oras yra apsiniaukęs");
            }
            else if (reiksme == 1)
            {
                Console.WriteLine("Dangus yra giedras");
            }
            else
            {
                Console.WriteLine("Nėra tokio pasirinkimo.");
            }
        }

    }
}
