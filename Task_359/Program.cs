using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_359
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 359зад. Съставете метод, който в даден знаков низ S търси подниз X, който 
             е предшестван или последван от поднизове A и B.*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете низ S:");
            string S = Console.ReadLine();
            DoMyCheck(S);
            
        }
        static string DoMyCheck(string S)
        {
            
            Console.WriteLine("Въведете низ Х");
            string X = Console.ReadLine();
            int Choice;
            Console.WriteLine("За А и В предшестащи, моля натиснете 1");
            Console.WriteLine("За А и В последващи, моля натиснете 2");
            Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                Console.WriteLine("Въведете низ A");
                string A = Console.ReadLine();

                Console.WriteLine("Въведете низ B");
                string B = Console.ReadLine();

                string Combined1 = A + B + X;
                Console.WriteLine("Предшестван от низове А и В : {0}", Combined1);

                if (S.Contains(X)&&Combined1.Contains(X))
                {
                    Console.WriteLine("В низът {0} има подниз {1}, предшестван от {2}", S, X, A+B);
                }
                else
                {
                    Console.WriteLine("Не съдържа низ Х");
                }


            }
            else
            {
                if(Choice == 2)
                {
                    Console.WriteLine("Въведете низ A");
                    string A = Console.ReadLine();

                    Console.WriteLine("Въведете низ B");
                    string B = Console.ReadLine();

                    string Combined2 = X + A + B;
                    Console.WriteLine("Последван от низове А и В : {0}", Combined2);
                    if (S.Contains(X) && Combined2.Contains(X))
                    {
                        Console.WriteLine("В низът {0} има подниз {1}, последван от {2}", S, X, A + B);
                    }
                    else
                    {
                        Console.WriteLine("Не съдържа низ Х");
                    }

                }
                else
                {
                    Console.WriteLine("1 or 2 not {0}", Choice);
                }
            }

            return X;
            
        }
        
    }
}
