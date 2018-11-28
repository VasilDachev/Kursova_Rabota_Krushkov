using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task380_2
{
    class Program
    {
        /* 380зад. Да се въведат от клавиатурата произволно число k и произволен брой ненулеви числа(за край на въвеждането служи числото 0).
         1. Да се отпечата сумата на тези от тях, които са нечетни.
         2. Да се въведат от клавиатурата 8 положителни числа. Да се намери и отпечата на екрана средно геометрично (корен осми от произведението)
         на тези числа.
         3. Да се създаде метод Sss(k), който генерира k на брой случайни цели числа и като резултата връща произведението на тези от тях, които
         са двуцифрени и завършват на 5. 
         В главния метод да се въведат 3 цели положителни числа a, b и с. Да се намери и отпечата:
         Sss(|a-b|)*Sss(b+c) */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c, d, e, f, g, h;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            g = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || e <= 0 || f <= 0 || g <= 0 || h <= 0)
            {
                Console.WriteLine("Въведи само положителни числа!");
            }
            else
            {
                int S = a * b * c * d * e * f * g * h;
                double n = 0.125;
                double geometrical = Math.Pow(S, n);
                Console.WriteLine("Средно геометрично е равно на : {0}", geometrical);
            }
            
        }
    }
}
