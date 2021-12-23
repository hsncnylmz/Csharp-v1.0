using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReadLine komutunu her zaman konsolu ekranda tutmak icin kullaniyorduk ama bunun bir ozelligi daha vardir.Bu dersimizde bunu gorucez
            //Kullanicidan aldigimiz degerleri tutmak icin kullanicaz.

            Console.WriteLine("Lütfen adınızı giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz:");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının adı:" + isim);
            Console.WriteLine("Kullanıcının soyadı:" + soyisim);

            Console.ReadLine();
        }
    }
}
