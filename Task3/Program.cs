using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ззад.Нека p=false, q=true. Да се изчисли: */
            Console.OutputEncoding = Encoding.UTF8;
            bool p = false;
            bool q = true;
            double sum1;
            sum1 = 3 * 9 / 2 % 5 / 3;
            Console.WriteLine("Първо у-е: {0}", sum1);
            Console.WriteLine("Второ у-е: {0}", p || !q);
            double sum2;
            sum2 = Math.Floor(Math.Cos(1));
            Console.WriteLine("Трето у-е: {0}", sum2);
        }
    }
}
