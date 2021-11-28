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

namespace Logging_JSON_UnitTest
{
    class JewelryDataWriter
    {
        private ILogger<JewelryDataWriter> _logger;

        public JewelryDataWriter()
        {
            _logger = (new ServiceCollection()
                .AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Information))
                .BuildServiceProvider())
                    .GetService<ILoggerFactory>()
                    .CreateLogger<JewelryDataWriter>();
        }

        public static List<Jewelry> SetJson(List<Jewelry> FullList, string FileAddress)
        {
            string data = JsonConvert.SerializeObject(FullList);
            Console.WriteLine(data);
            Console.ReadKey();
            File.WriteAllText(FileAddress, data);

            return FullList;
        }

    }
}
