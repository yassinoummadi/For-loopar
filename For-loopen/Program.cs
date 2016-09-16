using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loopen
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Övning 1
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            */

            /* Övning 2
            for (int i = 20; i >= 0; i=i-1)
            {
                Console.WriteLine(i);
            }
            */

            /* Övning 3
            for (int i = 0; i <= 50; i=i+2)
            {
                Console.WriteLine(i)
            }
            */

            /* Övning 1 (4)
            Console.Write("Mata in start: ");
            string in1 = Console.ReadLine();
           

            Console.Write("Mata in stop: ");
            string in2 = Console.ReadLine();
            int stop = int.Parse(in2);

            Console.Write("Mata in steg: ");
            string in3 = Console.ReadLine();
            int steg = int.Parse(in3);

            for (int start = int.Parse(in1); start<=stop ; start = start + steg)
            {
                Console.WriteLine(start);
            }

            */
            /* Övning 3 (5)
            Console.Write("Mata in heltal: ");
            string in1 = Console.ReadLine();
            int tal = int.Parse(in1);
            int summa = 0;
            var x = 0;

            for (tal = tal; tal >= x; x++)
                summa = summa + x;
            {
                Console.WriteLine("Summan av alla tal från 1 till " + in1 + " blir " + summa);
            }
            */
            /* Övning 4 (6)
            Console.Write("Mata in heltal: ");
            string in1 = Console.ReadLine();
            int tal = int.Parse(in1);
            var x = 1;

            if (tal < 21)
                Console.WriteLine("Hittade inga tal!");
            else {
                for (tal = tal; tal > x; x++)

                {
                    if (x % 3 == 0 && x % 7 == 0)
                    {
                        Console.WriteLine("Talet " + x +" är delbart med 3 och 7.");
                    }
                }
                */
            }
            

            
           

            


        }
    }
}
