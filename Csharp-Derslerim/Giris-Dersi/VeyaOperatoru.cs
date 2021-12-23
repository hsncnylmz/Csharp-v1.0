using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veya operatoru || ile gösterilir piping adı da verilebilir borulama anlamına gelir.
            // iki degisken arasındaki true bulur ve ekrana yazdırır. Ne kadar false olsa dahi eger bir adet bile true varsa ekrana yazdırır.
            //sadece false olması durumunda false yazdırır.
            //boolean veri tipi ile karsilastiralim.

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 5;

            //dogru calican

            bool kontrolet = sayi1 == sayi2 || sayi2 < sayi3;

            //icinde false olan

            bool kontrolet1 = sayi1 != sayi2 || sayi1 < sayi3;

            //hepsi false olan

            bool kontrolet2 = sayi3 == sayi2 || sayi2 > sayi1;

            Console.WriteLine(kontrolet2);
            Console.WriteLine(kontrolet1);
            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
