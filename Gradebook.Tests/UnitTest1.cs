using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    public partial class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        /// <summary>
        /// Test to check Average Function
        /// </summary>
        [Test]
        public void Test_to_checkAVGcomputation()
        {
            var testbook = new Book();
            testbook.add("1618", 25, 25, 50);
            testbook.add("1583", 25, 24, 50);
            testbook.add("1585", 24, 24, 50);
            double actualAVG = testbook.findAVG();

            double expectedAVG = (99.999 + 99.99 + 49.99) / 3;

            Assert.AreEqual(expectedAVG, actualAVG, 0.01);
        }

        /// <summary>
        /// Test to check count variable
        /// </summary>
        [Test]
        public void Test_to_checkStudentCount()
        {
            var testbook = new Book();
            testbook.add("1618", 25, 25, 50);
            testbook.add("1583", 25, 24, 50);
            testbook.add("1585", 24, 24, 50);

            double actualCount = testbook.count;

            double expectedCount = 3;

            Assert.AreEqual(expectedCount, actualCount);
        }

        /// <summary>
        /// Test to check max computation function
        /// </summary>
        [Test]
        public void Test_to_checkMaxcomputation()
        {
            var testbook = new Book();
            testbook.add("1618", 25, 25, 50);
            testbook.add("1583", 25, 24, 50);
            testbook.add("1585", 24, 24, 50);
            double actualmax = testbook.findMax();

            double expectedmax = Math.Round(99.999,2);

            Assert.AreEqual(expectedmax, actualmax, 0.001);
        }
    }
}
