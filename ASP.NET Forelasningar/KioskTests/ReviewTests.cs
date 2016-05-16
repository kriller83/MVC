using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kiosk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Tests
{
    [TestClass()]
    public class ReviewTests
    {
        const int NumberOfRatingsToUse = 10;

        [TestMethod()]
        public void tempTest()
        {
            
            var kiosk = new Kiosk();
            kiosk.Review = new List<Review>();
            kiosk.Review.Add(new Review() {Rating=8});
            var rater = new KioskRater(kiosk);
            var result = rater.ComputeOverallRate(NumberOfRatingsToUse);  //10 är antalet ratings

            var expected = 8;  //Refaktoriserar
            var actual = result.Rating;

            Assert.AreEqual(8, result.Rating);
        }

        [TestMethod]
        public void TestMethod_AverageForTWOReviews()
        {
            //först skapar vi en kiosk och sen gör ratings på det... dålig kod. 
        
            /*const int NumberOfRatingsToUse = 10;*/  //konstant. lägger den högst upp ovanför testmethod. 

            //var kiosk = new Kiosk();
            //kiosk.Review = new List<Review>();
            //kiosk.Review.Add(new Review() {Rating = 4});
            //kiosk.Review.Add(new Review() {Rating = 6});
            //var rater = new KioskRater(kiosk);

            /*var rater = BuildKiosk(new int[] {4,6});*/   //såhär kan man oxå skriva det... 


            //Bättre och mindre kod. 

            var myKiosk = BuildKiosk(4, 6);
            var rater = new KioskRater(myKiosk);



            var result = rater.ComputeOverallRate(NumberOfRatingsToUse);  //10 är antalet ratings
            var expected = 5;
            var actual = result.Rating;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_ComputedTwoRatings()
        {
            var data = BuildKiosk(3, 9);
            var rater = new KioskRater(data);
            var actual = rater.ComputeWeightedRate(NumberOfRatingsToUse);
            var expected = 6;
            Assert.AreEqual(expected, actual);
            

        }

        private Kiosk BuildKiosk(params int[] ratings)    //params = vi kan skicka in kommaseparerade värde. Tar hur många intar som helst och struntar i om det är vektorer eller intar.
        {
            var result = new Kiosk();
            result.Review = ratings.Select(r => new Review() {Rating = r}).ToList();
            return result;
        }  
}
}