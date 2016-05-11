using TDD_Retro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDD_Retro.Tests
{
    [TestFixture]
    public class SekvensBoxarTests
    {
        [Test]
        public void KvadratTest()
        {
            //Arrange
            SekvensBoxar square = new SekvensBoxar();

            //Act
            var actual = square.Square(5);
            var expected = 25;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Salary()
        {
            //Arrange
            SekvensBoxar salaryProvision = new SekvensBoxar();

            //Act
            var actual = salaryProvision.Salary(1000);
            var expected = 16090;

            //Assert
            Assert.That(actual, Is.EqualTo(expected), "Wrong salary" );
        }

        [Test]
        public void TimeCount()
        {
            SekvensBoxar hourCount = new SekvensBoxar();

            int expectedMinutes = 180;
            int expectedSeconds = 10800;

            int actualMinutes;
            int actualSeconds;

            hourCount.TimeCount(3, out actualMinutes, out actualSeconds);

            Assert.That(expectedMinutes, Is.EqualTo(actualMinutes), "Fel antal minuter");
            Assert.That(expectedSeconds, Is.EqualTo(actualSeconds), "Fel antal sekunder");
        }

        [Test]
        public void Numbers()
        {
            SekvensBoxar numberCount = new SekvensBoxar();

            int expectedSum = 30;
            double expectedMedian = 10;

            int actualSum;
            double actualMedian;

            numberCount.SumNumbers(8,10,12, out actualSum, out actualMedian);

            Assert.That(expectedSum, Is.EqualTo(actualSum), "Felaktig summa");
            Assert.That(expectedMedian, Is.EqualTo(actualMedian), "Felaktigt medelvärde");
        }

        [Test]
        public void Currency()
        {
            SekvensBoxar currencyTransformation = new SekvensBoxar();

            double expectedDollar = 18;
            double expectedPound = 12;

            double actualDollar;
            double actualPound; 

            currencyTransformation.Currency(5, out actualDollar, out actualPound);
        }

    }
}