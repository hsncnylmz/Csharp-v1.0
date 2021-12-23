using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Long veri tipi -9,223,372,036,854,775,808 to -9,223,372,036,854,775,807 arasında değer depolayabilmektedir.
            // 8 byte yer kaplar ram bellekte.

            long birinciDegisken = 574327773;
            long ikinciDegisken = -327472378;

            long MaxDegisken = long.MaxValue;
            long MinDegisken = long.MinValue;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(MaxDegisken);
            Console.WriteLine(MinDegisken);

            Console.ReadLine();

        }
    }
}
