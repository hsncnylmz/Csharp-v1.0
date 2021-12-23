using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esittir operatoru ==
            // Bu ders de int veri tipi ile ve esittir operatoru yardımıyla iki degerin birbirine esit olup olmadığına bakıcaz
            // vede boolean komutu ile true(dogru) veya false(yanlis) olup olmadığını konsola yazdıracağız.
            int sayi1 = 5;
            int sayi2 = 5;

            bool kontrol = sayi1 == sayi2;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}
