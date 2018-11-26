using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се състави програма, която
             изчислява и извежда на екрана
             околната повърхнина s и пълната
             повърхнина S на цилиндър, като се
             зададат височината H и радиуса 
             основата R, по формулите : ...*/
            double s, S, H, R, pie;
            pie = 3.14;
            Console.WriteLine("Please enter H>0 ");
            H = double.Parse(Console.ReadLine());
            if (H <= 0)
            {
                Console.WriteLine("I warned you!");
                
            }
            else
            {
                Console.WriteLine("Please enter R>0 ");
                R = double.Parse(Console.ReadLine());
                if (R <= 0)
                {
                    Console.WriteLine("Why you do this?");
                }
                else
                {
                    s = 2 * pie * R * H;
                    S = (2 * pie * R * H) + 2 * pie * Math.Pow(R, 2);
                    Console.WriteLine("The result for s is : {0}", s);
                    Console.WriteLine("The result for S is : {0}", S);
                }
            }
          
           
           

        }
    }
}
