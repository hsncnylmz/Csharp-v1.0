using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucukturVeKucukEsitOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kucuktur Operatoru : <
            //Kucuk Esittir Operatoru : <=
            // Bu dersimizde gorecegimiz operatorler de aynı sekilde buyuktur ve buyuk esittir operatorlerinde olan islemlerin aynisidir.
            // eger degiskenimiz sart kostugumuz degerimize esit ise konsolda bize false olarak donecektir cunku ayni iki deger birbirine esittir fakat kucuk degildir.

            int yas = 23;

            bool kontrol = yas < 23;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}
