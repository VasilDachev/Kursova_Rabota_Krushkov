using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task380
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
            int number,i;
            
            int[] arr = new int[100];
            for (i = 0; i < arr.Length; i++)
            {
                
                Console.Write("Enter number -> ");
                number = int.Parse(Console.ReadLine());
                
                if (number == 0)
                {

                    Console.WriteLine("0 was entered");         
                    break;

                }
                arr[i] = number;
                
            }
            int odd = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odd += arr[i];
                }
            }
            Console.WriteLine("The sum of all Odd numbers -> {0}", odd);
            
        }
    }
}
