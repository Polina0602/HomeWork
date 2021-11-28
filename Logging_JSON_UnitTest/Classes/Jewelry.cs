using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Logging_JSON_UnitTest.Interfaces;
using Logging_JSON_UnitTest.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Logging_JSON_UnitTest.Classes
{
    public class Jewelry : IJewelry
    {
       private ILogger<Jewelry> _logger;

        public string Metal { get; set; }
        public string Gem { get; set; }

        string NewJewelryCollection { get; set; }

        double PriceJewelryInDollars { get; set; }

       public double  PriceJewelryInShekel { get; set; }


        public string NewCollection()
        {
            NewJewelryCollection = "Winter Flowers";
            return NewJewelryCollection;
        }

        public Jewelry(string metal, string gem, double priceJewelryInDollars)
        {
            Metal = metal;
            Gem = gem;
            PriceJewelryInDollars = priceJewelryInDollars;

                PriceJewelryInShekel = Math.Round(PriceJewelryInDollars * 3.19, 2);


            //_logger = (new ServiceCollection()
            //.AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Information))
            //.BuildServiceProvider())
            //    .GetService<ILoggerFactory>()
            //    .CreateLogger<Jewelry>();



        }

        public double PriceInShekel(double PriceJewelryInDollars)
        {

            PriceJewelryInShekel = Math.Round(PriceJewelryInDollars / 3.19, 2);
            return PriceJewelryInShekel;
        }


        public override string ToString()
        {
            return "My jewelry: " + Metal + " " + Gem +", " + "Collection is " + NewJewelryCollection  + ". The price is " +  PriceJewelryInShekel + " ILS" + " and I love it!";
        }

    }
}
