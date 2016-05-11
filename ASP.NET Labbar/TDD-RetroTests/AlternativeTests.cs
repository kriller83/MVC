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
    public class AlternativeTests
    {
        [TestMethod()]
        public void BiggestNumberTest()
        {
            Alternative bigNumber = new Alternative();

            var actual = bigNumber.BiggestNumber(2, 5);
            var expected = 5;


            Assert.Fail();
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void BiggestNumberExceptionTest()
        {
            Alternative bigNumber = new Alternative();

            bigNumber.BiggestNumber(2, 5);

        }
    }
}