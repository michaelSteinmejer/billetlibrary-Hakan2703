using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Test
{
    [TestClass]
    public class TestOfDiscount
    {
        [TestMethod]
        public void TestBroBizz()
        {

            //Arrange
            Mc Biker = new Mc();


            //Act
            decimal pris = Biker.Price();



            //Assert
            Assert.AreEqual(125, pris);
        }
    }
}
