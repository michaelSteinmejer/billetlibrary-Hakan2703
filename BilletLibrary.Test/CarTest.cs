using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Test
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestCarPrice()
        {

            //Arrange
            Car bil = new Car();


            //Act
            decimal pris =  bil.Price();



            //Assert
            Assert.AreEqual(240, pris);
        }
    }
}
