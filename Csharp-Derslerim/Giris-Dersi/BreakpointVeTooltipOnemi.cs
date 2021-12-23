using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +=
            // -=
            // *=
            // /=
            // oncelikle bu yardımcı operatorler toplama cıkarma gibi islemleri yaparken bize verdigimiz degiskeni toplayip cikarirken tekrar 
            // bu islemleri yaparken degiskenimizi yazmamıza gerek kalmadan yapmamıza yarar

            int a = 5;

            // a = a + 3; //yapmak yerine yani turkcesi a degiskenini topla 3 ile sonra a degiskeninin icine koy bunun yerine

            a += 3; // yani a degiskenini 3 ile topla bu diger toplama cikarma carpma ve bolme islemlerinde de aynıdır. 

            Console.WriteLine("a ' nın değeri :"+a);
            Console.ReadLine();



        }
    }
}
