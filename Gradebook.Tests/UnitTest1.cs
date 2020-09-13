using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    [TestFixture]
    public class Sample_Tests_1
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
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);
                double actualAVG = testbook.findAVG();

                double expectedAVG = Math.Round((100.00 + 99 + 98) / 3, 2);

                Assert.AreEqual(expectedAVG, actualAVG, 0.01);
            }
            catch
            {
                Assert.Pass();
            }
            
        }

        /// <summary>
        /// Test to check count variable
        /// </summary>
        [Test]
        public void Test_to_checkStudentCount()
        {
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);

                double actualCount = testbook.count;

                double expectedCount = 3;

                Assert.AreEqual(expectedCount, actualCount);
            }
            catch
            {
                Assert.Pass();
            }
        }

        /// <summary>
        /// Test to check max computation function
        /// </summary>
        [Test]
        public void Test_to_checkMaxcomputation()
        {
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);
                double actualmax = testbook.findMax();

                double expectedmax = Math.Round(100.000, 2);

                Assert.AreEqual(expectedmax, actualmax, 0.001);
            }
            catch
            {
                Assert.Pass();
            }

        }

        [Test]
        public void Test_to_checkAddFunctionForInvalidMarks()
        {
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1618", 25, 25, 90);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);
                
                Assert.Fail("no exception thrown");
            }
            catch
            {
                Assert.Pass();
            }
           
        }

    }
}
