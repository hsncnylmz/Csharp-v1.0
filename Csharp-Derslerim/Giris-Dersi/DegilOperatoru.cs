using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegilOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Degil operatoru : ! (unlem) isaretidir.
            // Kısacası var olan bir seyin zıttına cevirir
            // == (esittir) != (esit degildir) gibi 
            // var olan birseyi zıttına cevirir

            bool a = true;

            //true yazdıracak
            Console.WriteLine(a);
            //false yazdıracak
            Console.WriteLine(!a);
            Console.ReadLine();
        }
    }
}
