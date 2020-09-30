using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{ 
    [TestFixture]
    public class Sample_Tests_2
    {
        /// <summary>
        /// Test to check min computation function
        /// </summary>
        [Test]
        public void Test_to_checkMincomputation()
        {
            var testbook = new Book();
            testbook.add("2017UCO1618", 25, 25, 50);
            testbook.add("2017UCO1583", 25, 24, 50);
            testbook.add("2017UCO1585", 24, 24, 50);
            double actualAVG = testbook.findAVG();
            
            double expectedAVG = Math.Round((100.00 + 99 + 98) / 3, 2);

            Assert.AreEqual(expectedAVG, actualAVG, 0.01);
        }
    }
}
