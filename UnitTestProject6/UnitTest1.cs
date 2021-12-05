using Logging_JSON_UnitTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject6
{
    [TestClass]
    public class JewelryPriceTest
    {
        [TestMethod]
        public void JewelryPriceInShekel()
        {
            // Arrange
            double PriceJewelryInDollars = 13;
            double expectedInShekel = Math.Round(PriceJewelryInDollars * 3.19, 2);

            //Act
            Jewelry jewelry = new Jewelry("", "", PriceJewelryInDollars);
            double actualPriceInShekel = jewelry.PriceInShekel();
            //Assert
            Assert.AreEqual(expectedInShekel, actualPriceInShekel);
        }
    }
}
