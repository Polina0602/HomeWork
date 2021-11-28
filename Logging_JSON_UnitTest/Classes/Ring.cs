using System;
using System.Collections.Generic;
using System.Text;
using Logging_JSON_UnitTest.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Logging_JSON_UnitTest.Classes
{
    class Ring : Jewelry, IRing, IJewelry
    {
        private ILogger<Jewelry> _logger;
        public double RingSize { get; set; }
        public double MySize { get; set; }

        string NewRingCollection { get; set; }

        public string NewCollection()
        {
            NewRingCollection = "Spring Flowers";
            return NewRingCollection;
        }
        public Ring(string metal, string gem, double ringsize, double priceInDollars) : base(metal, gem, priceInDollars)
        {
            RingSize = ringsize;


            //_logger = (new ServiceCollection()
            //.AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Information))
            //.BuildServiceProvider())
            //    .GetService<ILoggerFactory>()
            //    .CreateLogger<Ring>();

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

        public override string ToString()
        {
            return "My ring: " + Metal + " " + Gem + " Size " + RingSize + ", " + "Collection is " + NewRingCollection;
        }

    }
}
//options.SetMinimumLevel(LogLevel.Information);