using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pratybos
{
    class Zmogus
    {
        private int _organuKokybe; //eurais//atributas
        public int OrganuKokybe //property
        {
            get { return _organuKokybe; }
        }

        public string Lytis { get; } //get reiškia, kad gali tik nuskaityti
        public int Amzius { get; set; }
        public int PatirtuAvarijuSkaicius { get; }

        public Zmogus() { }

        public Zmogus (string lytis) //overloadinimas, matosi kuriant objektus
        {
            Lytis = lytis;
        }
        public Zmogus(int organuKokybe, string lytis, int amzius, int patirtuAvarijuSkaicius)
        {
            _organuKokybe = organuKokybe;
            Lytis = lytis;
            Amzius = amzius;
            PatirtuAvarijuSkaicius = patirtuAvarijuSkaicius;
        }


        public void Isvedimas()
        {
            Console.WriteLine("Šio žmogaus lytis {0}, o amžius {1}", Lytis, Amzius);
            Console.WriteLine("Žmogus patyrė {0} avarijų", PatirtuAvarijuSkaicius);
            Console.WriteLine("Už jo organus galima gauti {0} euru", _organuKokybe);
            Console.WriteLine();
        }
    }
}
