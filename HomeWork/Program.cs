using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWork.ObjectsAndClasses;

namespace HomeWork
{

    public enum Colors
    {
        Red,
        Blue,
        Green,
        Orange,
        Black

    }

    public class Point
    {
        public int x;
        public int y;
        public Colors color;
    }



    class Program
    {
        
       static void Main(string[] args)
        {
            // MyArray.MyArray1();
            // MyArray.MyArray2();
            // Triangles.Triangle();
            // EvenOdd.Evenodd();
            // MyArray.MyArrayUsersString();
            // MyArray.MyArraySearchElement();
            //MyArray.MyArraySearchLetters();
            //MyArray.ArrayChangeSize();
            //MyArray.ArrayAddElements();
            //Rectangles.Rectangle();
            //TableMultAndSimpleNumbers.tm();
            //Diamond.Romb();
            //FibonacciNumbers.Fibonacci();
            //Rekursia.ExampleRekursia("23 3 413 2487 3 5 788 1 3 5 814");
            PerfectNumbers.perfectNumbers();


            //var FirstStudent = GetStudent();
            //FirstStudent.Print();
        }
    }
}
