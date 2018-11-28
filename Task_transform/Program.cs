using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_transform
{
    class Program
    {
        static void Main(string[] args)
        {
            //2087 в 2, 8 и 16 -тична бройни системи.

            Console.OutputEncoding = Encoding.UTF8;

            int choice;
            Console.WriteLine("Изберете опции 1, 2, 3");
            Console.WriteLine("1-към двоична");
            Console.WriteLine("2-към осмична");
            Console.WriteLine("3-към шестнадесетична");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int number = int.Parse(Console.ReadLine());
                string Binary = Convert.ToString(number, 2);
                Console.WriteLine("Числото е {0}", Binary);
            }
            else
            {
                if (choice == 2)
                {
                    int number2 = int.Parse(Console.ReadLine());
                    string Octa = Convert.ToString(number2, 8);
                    Console.WriteLine("Числото е {0}", Octa);
                }
                else
                {
                    if (choice == 3)
                    {
                        int number3 = int.Parse(Console.ReadLine());
                        string Hexa = Convert.ToString(number3, 16);
                        Console.WriteLine("Числото е {0}", Hexa);
                    }
                    else
                    {
                        Console.WriteLine("Въведи число между 1 и 3 !");
                    }
                }
            }

            
        }
    }
}
