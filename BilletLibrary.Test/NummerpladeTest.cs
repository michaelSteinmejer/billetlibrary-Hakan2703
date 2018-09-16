using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BilletLibrary.Test
{ 

        [TestClass]
        public class NummerpladeTest
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void TestMCNummerplade()
            {

                //Arrange
                Mc Biker = new Mc();


                //Act
                Biker.Nummerplade = "123456789";
                

 


              
            }

        }
}
