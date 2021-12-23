using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukVeBuyukEsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Buyuktur Operatoru : >
            //Buyuk ve Esittir Operatoru : >=
            // Bu dersimiz de buyuktur isaretinin aynı deger verildiginde false ile döndügünü ama buyuktur ve esittir operatorlerini kullandıgımızda 
            // aynı deger verildiginde degiskenimize true olarak döndügünü görecegiz

            int yas2 = 18;
            // bu islemde 18 i false olarak yazdıracaktır cunku 18 18 e esittir ama buyuk degildir
            bool kontrol2 = yas2 > 18;

            int yas = 18;
            // ama bu islemde 18 18 e esit oldugu icin 18 i esit olarak kabul edecek ve true olarak bize donecektir.
            bool kontrol = yas >= 18;

            Console.WriteLine(kontrol2);
            Console.WriteLine(kontrol);
            Console.ReadLine();


        }
    }
}
