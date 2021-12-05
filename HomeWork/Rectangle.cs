using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Rectangles
    {

        static public void Rectangle()
        {
            Console.WriteLine("Height of rectangle = ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Width of rectangle = ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Sign is = ");
            char sign = char.Parse(Console.ReadLine());

            Console.WriteLine("Let's begin!");
            Console.WriteLine(" ");

            if (height <= 0)
            {
                throw new Exception(message: "Height is wromg!");
            }

            if (width <= 0)
            {
                throw new Exception(message: "Width is wromg!");
            }




        


                for (int i = 0; i <= height-2; i++)

                {
                    if (i == 0)
                    {
                        for (int j = 0; j<width; j++)

                        {
                            { Console.Write(sign); }

}
Console.WriteLine();
                    }
                    else
{
    for (int j = 0; j < width; j++)

    {
        if (j == 0)
        { Console.Write(sign); }
        else
        { Console.Write(" "); }
        if (j == width - 1)
        { Console.Write(sign); }
    }
    Console.WriteLine();
}
if (i == height - 2)
{
    for (int j = 0; j < width; j++)

    {
        { Console.Write(sign); }

    }
}

                }
                Console.WriteLine();

        }

    }
}
