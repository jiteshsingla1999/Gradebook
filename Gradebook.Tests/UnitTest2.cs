using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{ 
    public partial class Tests
    {
        /// <summary>
        /// Test to check min computation function
        /// </summary>
        [Test]
        public void Test_to_checkMincomputation()
        {
            var testbook = new Book();
            testbook.add("1618", 25, 25, 50);
            testbook.add("1583", 25, 24, 50);
            testbook.add("1585", 24, 24, 50);
            double actualmin = testbook.findMin();

            double expectedmin = Math.Round(98.0, 2);

            Assert.AreEqual(expectedmin, actualmin, 0.001);
        }
    }
}
