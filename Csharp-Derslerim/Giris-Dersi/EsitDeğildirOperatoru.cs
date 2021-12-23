using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsitDeğildirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esit degildir operatoru != isaretleridir. Kıyaslama yapmak iki degeri birbirine esit olup olmadıgını kontrol eder ve konsol ekranına yazdırır.
            //Boolean komutu ile birbirlerine olan kıyasının dogru(true) veya yanlıs(false) oldugunu gorebilmemizi saglayacaktır

            int sayi1 = 1;
            int sayi2 = 2;

            int sayi3 = 3;
            int sayi4 = 3;

            bool kontrol1 = sayi1 != sayi2;
            bool kontrol2 = sayi3 != sayi4;

            Console.WriteLine(kontrol1);
            Console.WriteLine(kontrol2);
            Console.ReadLine();
        }
    }
}
