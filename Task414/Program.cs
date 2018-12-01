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
            
            Console.Write("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());

            int[] arrayA = CreateString(n);
            int A = Calculating(arrayA);
            int[] arrayB = CreateString(n);
            int B = Calculating(arrayB);
            int[] arrayC = CreateString(n);
            int C = Calculating(arrayC);
            if (A > B && A > C)
            {
                Console.WriteLine("Biggest sum is {0}", A);
            }
            else
            {
                if (B > A && B > C)
                {
                    Console.WriteLine("Biggest sum is {0}", B);
                }
                else
                {
                    Console.WriteLine("Biggest sum is {0}", C);
                }
            }
            int p = -1;
            for (int k = 0; k < arrayC.Length; k++)
            {
                arrayC[k] = arrayA[k] * arrayB[k] * arrayB[k];
                for(int t = 0; t <= p; t++)
                {
                    arrayC[k] = arrayC[k] * arrayA[k] * arrayB[k] * arrayB[k];
                }
                p++;
            }
            for(int w = 0; w < arrayC.Length; w++)
            {
                Console.Write(" " + arrayC[w]);
                
            }

            Console.WriteLine(" ");
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
                
            }
            Console.WriteLine(" ");
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
