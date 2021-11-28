using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class ObjectsAndClasses
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
            int x;
            int y;
            Colors color;
        }

        Point point1 = new Point();

        //point1.x = 3;
        public class Student 
        {
            public int id;
            public string FirstName;
            public string SecondName;
            public string MiddleName;
            public int Age;
            public string Group;

            public void Print()
                {
                Console.WriteLine("Age:" + FirstName + MiddleName + SecondName);
            }
        }

        public static Student GetStudent()
        {
            Student student = new Student();

            student.Age = 19;
            student.id = 3;
            student.FirstName = "Sasha";
            student.MiddleName = "Sergeevich";
            student.SecondName = "Ivanov";
            student.Group = "A1";

            return student;
        }

       //public static void Print(Student student)
       // {
       //     Console.WriteLine("Age:" + student.FirstName + student.MiddleName + student.SecondName);
       // }



    }
}
