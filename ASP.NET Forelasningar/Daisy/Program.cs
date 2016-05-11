using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Daisy
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public int Add(int a, int b)
        {
            return a + b;

        }

        //personnummer test ÅÅ-MM-DD
        //datum: 
        [Test]

        public void PersonalNumber()
        {
            var prog = new Program();
            var actual = prog.Add(830610, 940510);
            var expected = 10;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]

        public void DateTest()
        {
            var prog = new Program();
            var start = 99 - 03 - 10;
            var end = 13 - 04 - 23;
            Assert.AreNotEqual(start, end);

        }

        public class CheckPerson  
        {
            public string CheckPersonNumber(string pnr)
            {
                if (pnr != "130229")
                    return pnr;
                else
                {
                    return "";
                }
                throw new NotImplementedException(); //Börjar alltid såhär!!! 
            }
        }

        [TestFixture]
        public class CheckPersonTest
        {

            //correct date in beginning
            [Test]

            public void CheckNumberBeginning()
            {
                //Arrange
                CheckPerson person = new CheckPerson();

                //Act
                var actual = person.CheckPersonNumber("20010101");
                var expected = "20010101";
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            //Correct date in the middle
            [Test] //måste säga at det ingår i testerna

            public void CheckNumberMiddle()
            {
                //arrange
                CheckPerson personMiddle = new CheckPerson();

                //Act
                var actual = personMiddle.CheckPersonNumber("080615");
                var expected = "080615";
                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Correct date in the end
            [Test]

            public void CheckNumberEnd()
            {
                //arrange
                var personEnd = new CheckPerson();

                //Act
                var actual = personEnd.CheckPersonNumber("161230");
                var expected = "161230";
                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Correct date in month
            [Test]

            public void CheckDateInMonth()
            {
                //arrange
                var person = new CheckPerson();

                //Act
                var actual = person.CheckPersonNumber("160509");
                var expected = "160509";
                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }


            //correct date in month
            //correct date in day
            //correct date in leapyear
            [Test]

            public void CheckNumber_LeapYear()
            {
                //Arrange
                CheckPerson person = new CheckPerson();
                //Act
                var actual = person.CheckPersonNumber("120229");
                var expected = "120229";
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            //incorrect date before
            //incorrect date after
            //incorrect date not leapyear
            [Test]

            public void CheckNumber_IncorrectLeapYear()
            {
                //Arrange
                CheckPerson person = new CheckPerson();
                //Act
                var actual = person.CheckPersonNumber("130229");
                string expected = null;
                //Assert
                Assert.That(actual, Is.Null);
            }

        }



        [Test]

        public void AddWrong()
        {
            var prog = new Program();
            //act - skapar actual och expected
            var actual = prog.Add(3, 4);
            var expected = 7;
            //assert
            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        [TestFixture]   //Hämta hem Nuggets: NUnitTDNet eller nunittestadapter
        public class ProgramTest
        {
            [Test]
            public void AddRight()
            {
                //arrange  - skapar en instans av programklassen
                var prog = new Program();
                //act - skapar actual och expected
                var actual = prog.Add(3, 4);
                var expected = 7;
                //assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}


