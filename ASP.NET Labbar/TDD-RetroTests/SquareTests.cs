using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Retro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Retro.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetSquareNumberTest_TextInString()
        {
            Square sq = new Square();
            sq.GetSquareNumber("fem");
        }

        [TestMethod()]
        [ExpectedException(typeof (Exception))]
        public void GetSquareNumberTest_NumberMultiplyNumberFault()
        {
            Square sq = new Square();
            sq.GetSquareNumber("2*2");
        }

        [TestMethod()]
        [ExpectedException(typeof (Exception))]
        public void GetSquareNumberTest_EmptyString()
        {
            Square sq = new Square();
            sq.GetSquareNumber("");
        }
        [TestMethod()]
        [ExpectedException(typeof (Exception))]
        public void GetSquareNumberTest_NumberTextFault()
        {
            Square sq = new Square();
            sq.GetSquareNumber("7d");
        }

        [TestMethod()]
        [ExpectedException(typeof (NullReferenceException))]
        public void GetSquareNumberTest_NullFault()
        {
            Square sq = new Square();
            sq.GetSquareNumber(null);
        }


        [TestMethod]
        public void GetSquareNumberTest_Correct()
        {
            //Arrange
            var sq = new Square();
            //Act
            var actual = sq.GetSquareNumber("0.8");
            var expected = 0.64;
            //Assert
            Assert.AreEqual(actual,expected, "0.8 test correct");
        }
    }
}