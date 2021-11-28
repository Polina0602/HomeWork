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


 //.AddSingleton<IJewelryDataReader, JewelryDataReader>()
        .BuildServiceProvider();

            _logger = _serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            _logger.LogInformation("Io-Hooooo!");


            #region Set json
            /// <summary>
            /// This creates a new json file from an array
            /// </summary>
            List<Jewelry> JewelryListSet = new List<Jewelry>();
            JewelryListSet.Add(new Jewelry("gold", "diamond"));
            JewelryListSet.Add(new Jewelry("platina", "sapphire"));
            JewelryListSet.Add(new Jewelry("gold", "topaz"));
            JewelryListSet.Add(new Jewelry("white gold", "sparkling diamond"));

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
                JewelryDataReader.Getjson(ref JewelryListTest, "C:/112/jewelry.json");
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

            Jewelry earring = new Jewelry("red gold", "gem");

            var t = earring.ToString();
            _logger.LogInformation(t);

            Ring GoldRing = new Ring("gold", "topaz", 14.5);

            GoldRing.Resize();

        }


    }

}
