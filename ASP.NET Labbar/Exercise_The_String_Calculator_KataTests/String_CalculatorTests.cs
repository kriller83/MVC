using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_The_String_Calculator_Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_The_String_Calculator_Kata.Tests
{
    [TestClass()]
    public class String_CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            String_Calculator kalkylator = new String_Calculator();

            //Act
            var actual = kalkylator.Add("1", "5");
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }
    }
}