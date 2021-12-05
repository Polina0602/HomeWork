using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Rekursia
    {
       
        public static void ExampleRekursia(string Numbers) 
        {
            Console.WriteLine("Write your number, please");
            string Number = (Console.ReadLine());
            bool ThereIsANumber = Numbers.Contains(Number);
            if (ThereIsANumber == true)
                {
                    int res = int.Parse(Number) + 1;
                    List<string> FinalRes = new List<string>();
                    
                    for (int i = res; i <= 999; i++)
                        {
                            res = i;
                            string resString = res.ToString();
                            FinalRes.Add(resString);
                        }
                             foreach (var item in FinalRes)
                {
                    Console.WriteLine(item);
                }
                
                }
        }


    }
}
