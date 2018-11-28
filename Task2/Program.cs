using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2зад. Да се запише според правилата на С# изразът(2-ра група):

            Console.OutputEncoding = Encoding.UTF8;
            double B = double.Parse(Console.ReadLine());
            double p = 3.14;
            double y = double.Parse(Console.ReadLine());
            double up;
            up = B + Math.Pow(Math.Sin(Math.Pow(p, 4)), 2);
            double down;
            double theRootIndex = 0.2;
            down = Math.Pow(Math.Sqrt(Math.Cos(6)), theRootIndex) + Math.Abs(Math.Atan(y));
            Console.WriteLine("Решението на уравнението е : {0}", up / down);
        }
    }
}
