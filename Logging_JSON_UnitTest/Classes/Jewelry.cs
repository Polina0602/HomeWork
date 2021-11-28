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

        bool _res;


public Jewelry(string metal, string gem)
        {
            Metal = metal;
            Gem = gem;
            //_logger = (new ServiceCollection()
            //.AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Information))
            //.BuildServiceProvider())
            //    .GetService<ILoggerFactory>()
            //    .CreateLogger<Jewelry>();



        }


        public void NewCollection()
        {
          // _logger.LogInformation($"New Collection {CollectionName}");
        }

        public override string ToString()
        {
            return "My jewelry: " + Metal + " " + Gem;
        }

    }
}
