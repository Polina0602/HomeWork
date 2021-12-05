using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class FibonacciNumbers
    {
        public static void Fibonacci()
            {
                int x = 0;
                int y = 1;
                Console.WriteLine("The upper bound is:");
                int bound = int.Parse(Console.ReadLine());

            List<int> Fibonacci = new List<int>();

            while (x < bound && y < bound)
            {
                y = x + y;
                if (y < bound)
                {
                        Fibonacci.Add(y);
                        x = x + y;
                            if (x < bound)
                            {
                                
                                Fibonacci.Add(x);
                            }
                }
            }

            foreach (var number in Fibonacci)
                {
                Console.Write(number + " ");
                
                }
            }
    }
}
