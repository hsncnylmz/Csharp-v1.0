using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && ve operatoru shift+6 ile iki adet yapıldığında ve olur. Kodlamada Ve demektir iki degiskenin oldugu yerlerde kullanılabilir.
            // && nin bize true dönebilmesi icin tüm sartların dogru(true) olması gerekmektedir. Eger bir sartımız dahi yanlıs false olursa konsolda bize false donecektir.

            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            bool kontrol = sayi1 == sayi2 && sayi1 < sayi3;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}
