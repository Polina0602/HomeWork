using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Logging_JSON_UnitTest.Interfaces;
using Logging_JSON_UnitTest.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Logging_JSON_UnitTest.Classes;

namespace Logging_JSON_UnitTest.Classes
{
    public class JewelryDataReader : IJewelryDataReader
    {
        private ILogger<JewelryDataReader> _logger;

        public JewelryDataReader()
        {
            //_logger = (new ServiceCollection()
            //    .AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Information))
            //    .BuildServiceProvider())
            //        .GetService<ILoggerFactory>()
            //        .CreateLogger<JewelryDataReader>();
        }


        //public static List<string> GetJewelryList()
        //    {
        //        AppData appData;
        //        using (StreamReader reader = new StreamReader("C:/111/jewelry.json"))
        //        {
        //            string json = reader.ReadToEnd();
        //            appData = JsonConvert.DeserializeObject<AppData>(json);

        //        }
        //        return appData.JewelryListGet;


        //    }
        public static List<Jewelry> Getjson( List<Jewelry> EmptyList, string FileAddress)
        {
            //try
            //{
                using (StreamReader reader = new StreamReader(FileAddress))
                {
                    string json = reader.ReadToEnd();
                EmptyList.AddRange( JsonConvert.DeserializeObject<List<Jewelry>>(json));

            }
            // }

            //catch (Exception ex)
            //{
            //    _logger.LogError(ex.Message);
            //}

            return EmptyList;

        }
    }
}