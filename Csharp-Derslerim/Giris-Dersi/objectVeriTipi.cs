using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object veri tipinde istediğimiz tüm veri tiplerini console da yazdırabiliriz daha öncede öğrendiğimiz string, short, double veri tiplerini object şekilde
            // console da yazdırabiliriz fakat işlem yaptıramayız.

            object a = "Hasan";
            object b = 10;
            object c = 10.13;
            object d = false;
            object e = 10 > 9;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
