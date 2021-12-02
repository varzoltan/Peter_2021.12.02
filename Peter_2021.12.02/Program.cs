using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peter_2021._12._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //típus nev érték vagy kifejezés
            //Karaktertípus:1
            char karakter = 'a';
            char karakter2 = karakter;

            //Karaktertípus:2:String
            string szoveg1 = "alma";

            Console.WriteLine(karakter + ":" + karakter2 + "\n" +szoveg1);
            Console.ReadKey();

        }
    }
}
