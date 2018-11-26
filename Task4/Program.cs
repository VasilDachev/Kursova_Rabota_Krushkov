using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4зад. Какви стойности има х(int x=3) след присвояването, ако double a=3, int b=4 ? */
            Console.OutputEncoding = Encoding.UTF8;
            int x1 = 3;
            double a = 3;
            int b = 4;
            
            Console.WriteLine("Ако не превърнем double в int, или обратното, изразите са грешни и нямат стойност!");
            
            int a1 = 3;
            x1 -= ++a1 + 2 * b;
            Console.WriteLine("След превръшане, x1 : {0}", x1);

            int x2 = 3;
            x2 = 2 * b++ + a1;
            Console.WriteLine("След превръшане, x2 : {0}", x2);

            int x3 = 3;
            x3 = --a1 / ++b;
            Console.WriteLine("След превръшане, x3 : {0}", x3);
        }
    }
}
