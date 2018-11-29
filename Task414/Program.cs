using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task414
{
    class Program
    {
        /*414зад. 
         1.Да се направят два метода:
            а)за въвеждане на едномерен целочислен масив;
            б)за изчисляване на сумата на тези елементи на целочисления масив,
            които са нечетни и принадлежат на интервала (0,100].
         2.В главния метод въведете цяло число n и три едномерни целочислени 
         масива A[n],B[n] и C[n]. За всеки масив изчислете и отпечатайте стойността 
         на сумата по точка 1б. Намерете и отпечатайте максималната от трите суми.
         3.Преизчеслете елементите на масива C по следния начин:
         (......) */
        static void Main(string[] args)
        {
            
            int br;
            int[] A;
            int[] B;
            int[] C;
            // for (br = 0; br < 3; br++)
            // {
            //     Console.Write("Enter array lenght:");
            //     int n = int.Parse(Console.ReadLine());
            //     Calculating(CreateString(n));
            // }
            // Console.WriteLine("");
            Console.Write("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());
            int a = Calculating(CreateString(n));
            int b = Calculating(CreateString(n));
            int c = Calculating(CreateString(n));
            if (a > b && a > c)
            {
                Console.WriteLine("Biggest sum is {0}", a);
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("Biggest sum is {0}", b);
                }
                else
                {
                    Console.WriteLine("Biggest sum is {0}", c);
                }
            }


        }
        static int[] CreateString(int n)
        {
            
            int number;
            int[] arr = new int [n];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number:");
                number = int.Parse(Console.ReadLine());
                arr[i] = number;
                
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0} ", arr[i]);
                Console.WriteLine(" ");
            }
            
            return arr;
        }
        static int Calculating(int[] arr)
        {
            int sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 != 0 && arr[j] > 0 && arr[j] <= 100)
                {
                    sum += arr[j];
                }
            }
            Console.WriteLine("The sum is {0}", sum);
            return sum;
        }
       
    }
}
