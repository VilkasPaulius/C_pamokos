using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pastatas pastatas = new Pastatas();
            pastatas.Ivedimas();
            pastatas.Isvedimas();
            pastatas.NaujaKainaPoAlgu();
            Console.WriteLine("Kaina po darbuotojų algų "+pastatas.Kaina);
        }
    }
}
