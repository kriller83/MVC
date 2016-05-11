using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Goofy3
{
    [TestFixture]
    class Goofy_Test
    {
        [Test]
        public void AddCorrectCalculation()
        {
            //arrange - behövs ej pga static 
            var expected = 5;
            //act
            var actual = Goofy3.Add(3, 2);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
