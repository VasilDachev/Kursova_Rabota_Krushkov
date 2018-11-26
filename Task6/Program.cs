using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)                   //public void Main(string[] args)
        {
            // 6зад.Открийте грешките:

            Console.OutputEncoding = Encoding.UTF8;

            double a = 2, c;                              //integer a = 2, c;
            double b = double.Parse(Console.ReadLine());  //c=Math.Sin(a)*Math.Cos(b)
            c = Math.Sin(a) * Math.Cos(b);                //b=Console.WriteLine()

            Console.WriteLine("Решението е : {0}", c);
        }
    }
}
