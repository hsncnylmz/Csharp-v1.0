using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int Veri Tiipi -2.147.483.648 ile 2.147.483.647 arasında değer depolayabilmektedir.
            // 4 byte yer kaplar ram bellekte

            // 8 bit = 1 byte
            // 1024 byte = 1 KB (Kilobyte)
            // 1024 KB = 1 MB (Megabyte)
            // 1024 MB = 1 GB (Gigabyte)
            // 1024 GB = 1 TB (Terabyte)
            // 1024 TB = 1 PB (Petabyte)

            int birinciDegisken = 150000;
            int ikinciDegisken = -500000;

            int MaxDeger = int.MaxValue;
            int MinDeger = int.MinValue;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);

            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);

            Console.ReadLine();

        }
    }
}
