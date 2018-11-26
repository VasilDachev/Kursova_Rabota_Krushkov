using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Тест 1, 2-ра група.
            /* 1зад. Кои от следните числови константи са записани според правилата на C# и кои не? 
             007
             112
             Е-4
             +0.1Е-20
             */
            Console.OutputEncoding = Encoding.UTF8;
            int E = 007;
            double f = 112;
            int newE = E - 4;
            //int nE = +0.1Е - 20;
            Console.WriteLine("Следователно правилно записаните константи са - 007, 112, Е-4 -, а - +0.1Е-20 - е грешно изписана.");

        }
      
    }
}
