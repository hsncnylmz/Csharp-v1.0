using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaVeCıkarmaOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toplama Operatoru +
            //Cıkarma Operatoru -

            int sayi1 = 11;
            int sayi2 = 17;
            int sayi3 = 5;
            int sayi4 = 10;

            int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
