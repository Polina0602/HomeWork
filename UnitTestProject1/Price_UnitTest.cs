using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logging_JSON_UnitTest;
using Logging_JSON_UnitTest.Classes;

namespace Logging_JSON_UnitTest.Test
{
    [TestClass]
    public class JewelryPriceTest
    {
        [TestMethod]
        public void JewelryPriceInShekel()
        {
            // Arrange
            double PriceJewelryInDollars = 38;

        //Act
            public PriceInShekel();
    //Assert
            Assert.AreEqual(11.91, PriceJewelryInShekel);
        }
    }
}
