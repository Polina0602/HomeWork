using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Triangles
    {
        static public void Triangle( )
        {

            Console.WriteLine("Height of Triangle = ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i < height; i++)
            {
                if (i > 1)
                {
                    for (int j = 1; j < i; j++)
                    {

                        Console.Write("o");

                    }
                }
                Console.WriteLine("o");
            }

            for (int i = height - 1; i > 0; i--)
            {
                if (i > 1)
                {
                    for (int j = i; j > 1; j--)
                    {
                        Console.Write("o");
                    }
                }
                Console.WriteLine("o");
            }
        }
    }
}
