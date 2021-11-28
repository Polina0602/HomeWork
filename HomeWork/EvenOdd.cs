using System;

namespace HomeWork
{
    class EvenOdd
    {
        static public void Evenodd()

        {
            Console.WriteLine("Number of array members: ");

            int b = 1;
            int sumOdd = 0;
            int sumEven = 0;
            int numberOfOdds = 0;
            int numberOfEvens = 0;

            int[] MyArray = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < MyArray.Length; i++)
            {

                MyArray[i] = b;
                b++;
                if (MyArray[i] % 2 == 0)
                {
                    Console.WriteLine(MyArray[i] + " - even");
                    sumEven = sumEven + MyArray[i];
                    numberOfEvens++;

                }
                else
                {
                    Console.WriteLine(MyArray[i] + " - odd");
                    sumOdd = sumOdd + MyArray[i];
                    numberOfOdds++;
                }
            }

            Console.WriteLine("Number of even numbers = " + numberOfEvens + ", sum of even numbers =" + sumEven);
            Console.WriteLine("Number of odd numbers = " + numberOfOdds + ", sum of odd numbers = " + sumOdd);

        }
    }

}


