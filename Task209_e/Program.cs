using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task209_e
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се генерира редица от 100 случайни цели числа, принадлежащи на интервала [0,132]...
             е) принадлежат на интервала (26,100];
             */
            int Min = 0;
            int Max = 132;
            int[] arr = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(Min, Max);
                //Console.WriteLine(arr[i]);
                if (arr[i] > 26 && arr[i] <= 100)
                {
                    Console.WriteLine("(26<  {0}  <=100]", arr[i]);
                }
                else
                {
                    Console.WriteLine(" ");

                }
            }
            Console.ReadLine();
        }
    }
}
