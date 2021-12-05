using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Diamond
    {
        public static void Romb() 
        {

            Console.Write("Height of romb: ");
            var height = int.Parse(Console.ReadLine());
            Console.WriteLine();
           if (height % 2 == 0) 
                {
                    height = height + 1;
                }
            
            //full
            for (int i = 0; i < height; i++)
            {
                int emptyPlace = Math.Abs(height / 2 - i);
                int signs = (height - 2 * emptyPlace);
                string NumberOfEmptyPlaces = new string(' ', emptyPlace);
                string NumberOfSigns = new string('*', signs);
                Console.Write(NumberOfEmptyPlaces);
                Console.Write(NumberOfSigns);
                Console.WriteLine();
                
            }
            Console.WriteLine();



            //Empty
            string SignsInEmptyRomb = new string(' ', height / 2);
            Console.Write(SignsInEmptyRomb);
            Console.Write('*');
            Console.WriteLine();
            for (int i = 1; i < height - 1; i++)
            {
                int EmptySpacesAround = Math.Abs(height / 2 - i);
                int EmptySpacesInside = height - 2 * EmptySpacesAround - 2;
                string NumberOfEmptyPlaces = new string(' ', EmptySpacesAround);
                string NumberOfSigns = new string(' ', EmptySpacesInside);
                Console.Write(NumberOfEmptyPlaces);
                Console.Write("*");
                Console.Write(NumberOfSigns);
                Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(SignsInEmptyRomb);
            Console.Write('*');
            Console.Read();


        }
    }
}
