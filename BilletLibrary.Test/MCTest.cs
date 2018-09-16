﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Test
{

    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void TestMCPrice()
        {

            //Arrange
            Mc Biker = new Mc();
            Biker.BroBizz = true;


            //Act
            decimal pris = Biker.Price();



            //Assert
            Assert.AreEqual(125, pris);
        }
    }
}
