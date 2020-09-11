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
            testbook.add("1618", 99.999);
            testbook.add("1583", 99.99);
            testbook.add("1585", 49.99);
            double actualmin = testbook.findMin();

            double expectedmin = Math.Round(49.99, 2);

            Assert.AreEqual(expectedmin, actualmin, 0.001);
        }
    }
}
