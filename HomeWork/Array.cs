using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class MyArray
    {
        static public void MyArray1()
        {
            int[] Numbers = new int[5];
            int even = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("Input number");
                Numbers[i] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("Numbers reverse: ");

            for (int i = Numbers.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(Numbers[i]);
                if (Numbers[i] % 2 == 0)
                {

                    even = even + Numbers[i];
                }

            }
            int max = Numbers.Max();
            Console.WriteLine("Numbers max = :" + " " + max);
            Console.WriteLine("Sum of evens = :" + " " + even);
        }

        internal static void MyArrayChangeSize()
        {
            throw new NotImplementedException();
        }

        static public void MyArray2()
        {
            int newString = 0;

            int[,] Tab = new int[5, 4]

            {
                {2, 5, 34, 0 },
                {87,4, 45, 1 },
                {3, 678, 5, 2 },
                {21, 65, -56, 3 },
                {456, 1, 4, 4 }
            };

            foreach (var item in Tab)
            {

                if (newString % Tab.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }

                Console.Write(item + " ");
                newString++;
            }
        }

        static public void MyArrayUsersString()
        {
            bool c = true;
            List<string> MyFinalString = new List<string>();
            do
            {
                Console.WriteLine("Symbol is ");
                string MySymbol = Console.ReadLine();

                Console.WriteLine("Number of symbols is ");
                int NumberOfSymbols = int.Parse(Console.ReadLine());

                string[] MyString = new string[NumberOfSymbols];

                for (int i = 0; i < NumberOfSymbols; i++)
                {

                    MyString[i] = MySymbol;
                    Console.Write(MyString[i]);

                    MyFinalString.Add(MyString[i]);


                }

                MyFinalString.Add(" ");

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? Y (yes) or N (no)");
                string MyAnswer = Console.ReadLine();
                if (MyAnswer == "Y" || MyAnswer == "y")
                {
                    c = true;
                }
                else
                {
                    c = false;
                }
            }
            while (c);

            Console.Write("My string is ");
            foreach (string MyString in MyFinalString)
            {
                Console.Write(MyString);
            }

            Console.ReadLine();
        }

        static public void MyArraySearchElement()
        {

            Console.WriteLine("Write your number ");
            int MyNumber = int.Parse(Console.ReadLine());

            int[] ArrayForSearch = new int[20];
            Random RundomNumber = new Random();

            bool end = true;

            for (int i = 0; i < ArrayForSearch.Length; i++)
            {
                int value = RundomNumber.Next(0, 10);
                ArrayForSearch[i] = value;

            }

            for (int i = 0; i < ArrayForSearch.Length; i++)
            {

                Console.Write(ArrayForSearch[i] + " ");


            }

            Console.WriteLine();

            for (int i = 0; i < ArrayForSearch.Length; i++)
            {
                if (ArrayForSearch[i] == MyNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("We got it! The index of element " + MyNumber + " is " + i);
                    end = false;
                    break;
                }
            }

            if (end)
            {
                Console.WriteLine("There is no element " + MyNumber + " in this array");
            }
            Console.ReadLine();

        }

        static public void MyArraySearchLetters()
        {

            #region New Collections
            string[] MyString = new string[5];
            List<string> MyNewList = new List<string>();
            #endregion

            for (int i = 0; i < MyString.Length; i++)
            {
                Console.WriteLine("Print a word ");
                MyString[i] = Console.ReadLine();
            }
            MyNewList.ToString().ToLower();

            Console.WriteLine("Print your letters ");
            string MyLetters = Console.ReadLine();

            for (int i = 0; i < MyString.Length; i++)
            {

                int LetterPlace = MyString[i].IndexOf(MyLetters);
                //Console.WriteLine(LetterPlace);
                // bool intyes = Convert.ToBoolean(LetterPlace);
                if (LetterPlace != -1)
                {
                    MyNewList.Add(MyString[i]);
                }
            }
            foreach (var item in MyNewList)
            {
                Console.Write(item + "");
            }
        }

        
        static public void ArrayChangeSize()

        {

            int [] ChangeSize = {5, 7, 23, 14, 8};
            Console.WriteLine("Write your number");
           int newsize = int.Parse(Console.ReadLine());

            Resize(ref ChangeSize, newsize);


            void Resize(ref int [] Oldarray, int newsize)
                {

                int[] Newarray = new int[newsize];
                for (int i = 0; i < Oldarray.Length && i < Newarray.Length; i++)
                    {
                    Newarray[i] = Oldarray[i];
                    }

                Oldarray = Newarray;
                }
        }

        static public void ArrayAddElements()

        {

            int[] ChangeSize = { 5, 7, 23, 14, 8 };
            Console.WriteLine("Which number you want to add?");
            int newElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the place: f (first), l (last), m (my choice)");
            string place = Console.ReadLine();





            void Resize(ref int[] Oldarray, int newElement)
            {
                int[] Newarray = new int[Oldarray.Length + 1];

                if (place == "m")
                {
                    Console.WriteLine("My choice is :");
                    int newElementPlace = int.Parse(Console.ReadLine());
                    for (int i = 0; i < Newarray.Length; i++)
                    {
                        if (i < newElementPlace)
                        { 
                        Newarray[i] = Oldarray[i];
                        }
                        if (i == newElementPlace)
                        {
                            Newarray[i] = newElement;
                        }
                        if (i > newElementPlace)
                        {
                            Newarray[i] = Oldarray[i-1];
                        }

                    }


                }

                if (place == "f")
                {
                    Newarray[0] = newElement;
                    for (int i = 1; i < Newarray.Length; i++)
                    {
                        Newarray[i] = Oldarray[i - 1];
                    }
                }
                else if (place == "l")
                {

                    for (int i = 0; i < Newarray.Length; i++)
                    {
                        
                        if (i == Oldarray.Length)
                        { Newarray[i] = newElement; }
                        else
                        {
                            Newarray[i] = Oldarray[i];
                        }

                    }
                }

                Oldarray = Newarray;
            }

            Resize(ref ChangeSize, newElement);
        }


    }
 }






    





