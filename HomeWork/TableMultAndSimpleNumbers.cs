using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class TableMultAndSimpleNumbers { 
    static public void tm ()
    {

        int lineNumber = 1;
        int columnNumber = 1;
        int res;
        int height = 10;
        int width = 10;
        bool sn;
        int counter = 1;

        for (int p = 0; p<width*1.6; p++)
            {
                Console.Write("___");
            }
    Console.WriteLine();

            for (int i = 0; i<height; i++)

            {

                for (int j = 0; j<width; j++)
                {


                    res = lineNumber* columnNumber;


    Console.Write("{0,4}", res);
                    Console.Write("|");


                    columnNumber++;
                }
//if (lineNumber % 2 == 0) { Console.WriteLine("_"); }

Console.WriteLine();
for (int p = 0; p < width * 1.6; p++)
{
    Console.Write("___");
}
Console.WriteLine();

lineNumber++;
columnNumber = 1;
            }
            //for (int p = 0; p < width*2; p++)
            //{
            //    Console.Write("___");
            //}
            Console.WriteLine();

Console.WriteLine();

for (int i = 2; i <= 9; i++)
{
    sn = true;
    //if (i % 2 != 0) { 

    for (int j = 2; j < i; j++)
    {

        if (i % j == 0)
        {
            sn = false;
            break;
        }
        counter++;
    }

    if (sn == true)
    {
        Console.WriteLine(i);
        sn = true;
    }
    // }
}

Console.WriteLine(counter);
        }
                
            
    }
}
