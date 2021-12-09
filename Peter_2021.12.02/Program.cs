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
            string szoveg2 = "fa";

            Console.WriteLine(karakter + ":" + karakter2 + "\n" +szoveg1+szoveg2 + " " + szoveg1.Replace("a","ó"));

            //Egész típus
            int ertek1 = int.MinValue;
            int ertek2 = int.MaxValue;
            long ertek3 = long.MinValue;
            long ertek4 = long.MaxValue;
            Console.WriteLine("Integer minimumértéke:" + ertek1);
            Console.Write("Integer maximumértéke:" + ertek2+"\n");
            Console.WriteLine("Long minimumértéke:" + ertek3);
            Console.Write("Long maximumértéke:" + ertek4);

            //boolean: True;False;0;1
            bool igaz = true;
            bool hamis = false;
            int a = 2;
            if(a != 2)
            {
                Console.WriteLine(igaz + "Igaz");
                //a = 3;
            }
            else
            {
                igaz = false;
                Console.WriteLine(igaz + "Hamis");
                
            }

            //double: duplapontos lebegőszám!
            int b = 10;
            int c = 100;
            double dupla = b * c;
            //b = dupla / c;
            Console.WriteLine("Eredmény: " + dupla);
            Console.WriteLine("Eredmény: " + dupla/10000);
            Console.ReadKey();

        }
    }
}
