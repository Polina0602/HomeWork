using System;
using System.Collections.Generic;
using System.IO;
using Logging_JSON_UnitTest.Classes;
using Logging_JSON_UnitTest.Interfaces;
using Logging_JSON_UnitTest.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Logging_JSON_UnitTest
{
    class Program
    {

        private static ILogger<Program> _logger;
        private static ServiceProvider _serviceProvider;
        static void Main(string[] args)
        {

            _serviceProvider = new ServiceCollection()
            .AddLogging(options =>
            {
                options.AddConsole();
                options.SetMinimumLevel(LogLevel.Information);
            })


        .BuildServiceProvider();

            _logger = _serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            _logger.LogInformation("Io-Hooooo!");


            #region Set json
            /// <summary>
            /// This creates a new json file from an array
            /// </summary>
            List<Jewelry> JewelryListSet = new List<Jewelry>();
            JewelryListSet.Add(new Jewelry("gold", "diamond", 1000));
            JewelryListSet.Add(new Jewelry("platina", "sapphire", 28));
            JewelryListSet.Add(new Jewelry("gold", "topaz", 345));
            JewelryListSet.Add(new Jewelry("white gold", "sparkling diamond", 10000005));

            foreach (Jewelry jewelry in JewelryListSet)
            {

                    _logger.LogInformation(jewelry.ToString());
            }


            
                JewelryDataWriter.SetJson(JewelryListSet, "C:/222/jewelry.json");


            #endregion


            #region Get json
            /// <summary>
            /// This creates a new array from the jason file
            /// </summary>
            List<Jewelry> JewelryListTest = new List<Jewelry>();

            try
            {
                 JewelryDataReader.Getjson(JewelryListTest, "C:/111/jewelry.json");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            foreach (var item in JewelryListTest)
            {
                _logger.LogInformation(item.ToString());
            }
            #endregion


            #region Lewelry and Collections
            /// <summary>
            /// This creates jewelry items
            /// </summary>
            Jewelry earring = new Jewelry("red gold", "gem", 45.14);
            earring.NewCollection();
            double inShekel = earring.PriceInShekel();
            var e = earring.ToString();
            _logger.LogInformation(e);

            Ring GoldRing = new Ring("gold", "topaz", 14.5, 4);
            GoldRing.NewCollection();
            GoldRing.Resize();
            var gr = GoldRing.ToString();
            _logger.LogInformation(gr);
            #endregion
        }


    }

}
