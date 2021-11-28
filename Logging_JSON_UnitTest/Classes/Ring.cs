using System;
using System.Collections.Generic;
using System.Text;
using Logging_JSON_UnitTest.Interfaces;

namespace Logging_JSON_UnitTest.Classes
{
    class Ring : Jewelry, IRing
    {
        public double RingSize { get; set; }
        public double MySize { get; set; }
        public Ring(string metal, string gem, double ringsize) : base(metal, gem)
        {
            RingSize = ringsize;
        }

        public void Resize()
        {

            Console.WriteLine("Your ring size is:");
            MySize = double.Parse(Console.ReadLine());

            if (RingSize != MySize)
                {
                Console.WriteLine("Your need resize this ring");
                }
        }

    }
}
//  options.SetMinimumLevel(LogLevel.Information);