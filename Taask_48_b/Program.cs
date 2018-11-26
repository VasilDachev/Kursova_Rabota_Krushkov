using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taask_48_b
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Зад48. Запишете като фрагмент от програма следната функция:
             б) y=x+2 за x<=0, y=x-2 за 0<x<1 и y=3x за x>=1  
             */
            Console.WriteLine("Enter X:");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x <= 0)
            {
                y = x + 2;
            }
            else
            {
                if (x < 1 && x > 0)
                {
                    y = x - 2;
                }
                else
                {
                    y = 3 * x;
                }
            }
            Console.WriteLine("The result is {0}", y);
        }
    }
}
