using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logging_JSON_UnitTest;

namespace Logging_JSON_UnitTest.Test
{
    [TestClass]
    public class JewelryPriceTest
    {
        [TestMethod]
        public void JewelryPriceInSHekel()
        {
            // Arrange
            double PriceJewelryInDollars = 38;

        //Act
            public PriceJewelryInShekel();
    //Assert
            Assert.AreEqual(11.91, PriceJewelryInShekel);
        }
    }
}
