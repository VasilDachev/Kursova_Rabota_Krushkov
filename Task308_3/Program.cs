using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task308_3
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
            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a>0.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b>0.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c>0.");
            int c = int.Parse(Console.ReadLine());

            int firstPart = Sss(Math.Abs(a - b));
            int secondPart = Sss(b + c);
            int Product;
            Product = firstPart * secondPart;
            if (Product == 1)
            {
                Console.WriteLine("No matching numbers were generated");
            }
            else
            {
                Console.WriteLine("End porudct is {0}",Product);
            }
            


        }
        static int Sss(int k)
        {
            int []arr= new int [k];
            Random rnd = new Random();
            int sum = 1;
            int i;
            for (i = 0; i < k; i++)
            {
                arr[i] = rnd.Next(0,200); //Сложих граница понеже генерира огромни числа повечето пъти, а идеята е да видим, че работи.
                Console.WriteLine("Generated number -> {0}", arr[i]);  
            }
            for (i = 0; i < k; i++)
            {
                if(arr[i] >= 10 && arr[i] <= 99 && arr[i] % 10 == 5)
                {
                   sum *= arr[i];
                }
                
            }
            if (sum == 1)
            {
                Console.WriteLine("No matching numbers.");
            }
            else
            {
                Console.WriteLine("The product is {0}", sum);
            }
            return sum;
        }
    }
}
