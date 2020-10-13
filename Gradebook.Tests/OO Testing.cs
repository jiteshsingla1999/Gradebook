using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{ 
    [TestFixture]
    [Category("Object Oriented Tests")]
    public class OO_Testing
    {
        private Book testbook;
        private Marks testmarks;
        [SetUp]
        public void Setup()
        {
            // Runs before each test executes
            testbook = new Book();
        }

        /// <summary>
        /// Initially the test cases are for verifying the Method Level Testing
        /// wherein every function for every class is Tested to check whether it 
        /// produces the desired result or not.
        /// </summary>
        [Test]
        public void Test_GetAggregate()
        {
            try
            {
                testmarks = new Marks(20, 20, 40);
                double actualsum = testmarks.getaggregatemarks();
                double expectedsum = 80.00;
                Assert.AreEqual(expectedsum, actualsum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_GetGrade()
        {
            try
            {
                testmarks = new Marks(23, 21, 44);
                string actualgrade = testmarks.getGrade();
                string expectedgrade = "A";
                Assert.AreEqual(expectedgrade, actualgrade);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_Add1()
        {
            try
            {
                testbook.add("2017UCO1583",20,20,40);
                Assert.Pass("Valid Values");
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_Add2()
        {
            try
            {
                testbook.add("2017UCO1500",-2, 20, 40);
                Assert.Fail("Invalid Values");
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correctly Caught Error");
            }
        }

        [Test]
        public void Test_Add3()
        {
            try
            {
                testbook.add("2017UBT1001", 20, 20, 40);
                Assert.Fail("Invalid Values");
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correctly Caught Error");
            }
        }

        [Test]
        public void Test_findsum()
        {
            try
            {
                testbook.add("2017UCO1501", 20, 20, 40);
                testbook.add("2017UCO1502", 10, 20, 35);
                testbook.add("2017UCO1503", 23, 24, 45);
                testbook.add("2017UCO1504", 20, 20, 20);
                double actualsum = testbook.findSum();
                double expectedsum = 297.00;
                Assert.AreEqual(expectedsum, actualsum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_findAVG()
        {
            try
            {
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);
                double actualAVG = testbook.findAVG();
                double expectedAVG = Math.Round((100.00 + 99 + 98) / 3, 2);
                Assert.AreEqual(expectedAVG, actualAVG, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test_findMIN()
        {
            try
            {
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 18, 50);
                testbook.add("2017UCO1585", 14, 24, 50);
                double actualMIN = testbook.findMin();
                double expectedMIN = 88.00;
                Assert.AreEqual(expectedMIN, actualMIN, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_findMAX()
        {
            try
            {
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 18, 50);
                testbook.add("2017UCO1585", 14, 24, 50);
                double actualMIN = testbook.findMax();
                double expectedMIN = 100.00;
                Assert.AreEqual(expectedMIN, actualMIN, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

    }
}
