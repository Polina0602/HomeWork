using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class PerfectNumbers
    {
       public static void perfectNumbers() 
        {
            Console.WriteLine("Write upper bound:");
            int UpperBound = int.Parse(Console.ReadLine());
            int PerfectNumber = 1;
            List<int> PerfectNumbers = new List<int>();

            for (int i = 1; i <= UpperBound; i++)
            {
                for (int j = 2; j <= UpperBound; j++)
                    {
                    if (i != j && i % j == 0)
                        {
                            int diviser = i / j;
                            PerfectNumber += diviser;
                        }
                    
                }

                if (i == PerfectNumber && i != 1)
                {
                    PerfectNumbers.Add(i);
                }
                PerfectNumber = 1;

            }
            foreach (var item in PerfectNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
