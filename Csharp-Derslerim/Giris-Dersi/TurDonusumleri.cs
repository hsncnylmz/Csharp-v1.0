using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tür dönüşümleri Nedir?
            Her iki taraf aynı veri tipinde olmak zorunda
            int veri tipini string veri tipine double veri tipinden int veri tipine dönüştürebilirim.Türler arası dönüşümdür.
            */
            /*
             * bu örnek şunu unutmamak için veriyorum byte veri tipinde 255 e kadar veri tutabiliriz. bu örnekte veri kaybı yaşayacağız.
            
            int a = 500;
            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();

            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* Örnek 1 (İnt veri tipinden byte veri tipine dönüştürme.

            int a = 5;
            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();

            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //string veri tipinden int veri tipine dönüştürme
            /*
            String sayi1 = "5";
            String sayi2 = "6";
            //birinci yöntem
            int a = int.Parse(sayi1);
            int b = int.Parse(sayi2);
            //ikinci yöntem
            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine(a + b);
            Console.ReadLine();
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //int veri tipinden string veri tipine dönüştürme
            /*
            int sayi1 = 5;
            int sayi2 = 11;

            string a = sayi1.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(a+b);
            Console.ReadLine();
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Double veri tipinden int veri tipine dönüştürme
            /*
            double sayi = 5.22;

            int a = Convert.ToInt32(sayi); 

            Console.WriteLine(sayi);
            Console.WriteLine(a);
            //GetType komutu verinin hangi veri ile yazıldığını görmenizi sağlar
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Kullanıcıdan alınan değerler string veri tipinde olur
            /*
            Console.WriteLine("Lütfen Yaşınızı Giriniz:");

            string kullanici_yasi = Console.ReadLine();

            //bunları int veri tipine dönüştürün

            int kullaniciyasi_int = int.Parse(kullanici_yasi);
            int kullaniciyasiint2 = Convert.ToInt32(kullanici_yasi);

            Console.WriteLine(kullaniciyasi_int);
            Console.WriteLine(kullaniciyasiint2);
            Console.ReadLine();
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Kullanıcıdan 2 tane sayı alan ve ikisinin farkını alan programı yazınız.

            Console.WriteLine("Lütfen Yaşınızı Giriniz:");
            string kullanici_yasi = Console.ReadLine();
            Console.WriteLine("Lütfen farkını almak istediğiniz yaşı yazınız:");
            string yas_farki = Console.ReadLine();
            
            int kullanici_yasi_int = Convert.ToInt32(kullanici_yasi);
            int yas_farki_int = Convert.ToInt32(yas_farki);

            int fark = (kullanici_yasi_int - yas_farki_int);
            Console.WriteLine("Aranızdaki yaş farkı:");
            Console.WriteLine(fark);
            Console.ReadLine();

        }
    }
}
