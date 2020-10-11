using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{ 
    [TestFixture]
    [Category("Object Oriented Tests")]
    public class OO_Testing
    {
        private Book1 testbook1;
        private Marks testmarks;
        private Book2 testbook2;
        private PracticalMarks testmarks2;
        private Statistics teststats;
        [SetUp]
        public void Setup()
        {
            // Runs before each test executes
            testbook1 = new Book1();
            testbook2 = new Book2();
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
                testbook1.add("2017UCO1583",20,20,40);
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
                testbook1.add("2017UCO1500",-2, 20, 40);
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
                testbook1.add("2017UBT1001", 20, 20, 40);
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
                testbook1.add("2017UCO1501", 20, 20, 40);
                testbook1.add("2017UCO1502", 10, 20, 35);
                testbook1.add("2017UCO1503", 23, 24, 45);
                testbook1.add("2017UCO1504", 20, 20, 20);
                double actualsum = testbook1.findSum();
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
                testbook1.add("2017UCO1618", 25, 25, 50);
                testbook1.add("2017UCO1583", 25, 24, 50);
                testbook1.add("2017UCO1585", 24, 24, 50);
                double actualAVG = testbook1.findAVG();
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
                testbook1.add("2017UCO1618", 25, 25, 50);
                testbook1.add("2017UCO1583", 25, 18, 50);
                testbook1.add("2017UCO1585", 14, 24, 50);
                double actualMIN = testbook1.findMin();
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
                testbook1.add("2017UCO1618", 25, 25, 50);
                testbook1.add("2017UCO1583", 25, 18, 50);
                testbook1.add("2017UCO1585", 14, 24, 50);
                double actualMIN = testbook1.findMax();
                double expectedMIN = 100.00;
                Assert.AreEqual(expectedMIN, actualMIN, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_UpdateStats()
        {
            try
            {
                testbook1.add("2017UCO1585", 14, 24, 49);
                teststats = testbook1.stats;
                double actualavg = teststats.avg;
                double expectedavg = 87.00;
                Assert.AreEqual(expectedavg, actualavg);
                double actualmin = teststats.lowval;
                double expectedmin = 87.00;
                Assert.AreEqual(expectedmin, actualmin);
                double actualmax = teststats.highval;
                double expectedmax = 87.00;
                Assert.AreEqual(expectedmax, actualmax);

                testbook1.add("2017UCO1618", 25, 25, 49);
                teststats = testbook1.stats;
                actualavg = teststats.avg;
                expectedavg = 93.00;
                Assert.AreEqual(expectedavg, actualavg);
                actualmin = teststats.lowval;
                expectedmin = 87.00;
                Assert.AreEqual(expectedmin, actualmin);
                actualmax = teststats.highval;
                expectedmax = 99.00;
                Assert.AreEqual(expectedmax, actualmax);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }


        public void Test_GetAggregate2()
        {
            try
            {
                testmarks = new PracticalMarks(10, 10, 10, 10, 10);
                double actualsum = testmarks.getaggregatemarks();
                double expectedsum = 50.00;
                Assert.AreEqual(expectedsum, actualsum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_Add12()
        {
            try
            {
                testbook2.add("2017UCO1618", 15, 15, 40, 15, 15);
                Assert.Pass("Valid Values");
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_Add22()
        {
            try
            {
                testbook2.add("2017UCO1500", -2, 20, 40, 23, 32);
                Assert.Fail("Invalid Values");
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correctly Caught Error");
            }
        }

        [Test]
        public void Test_Add32()
        {
            try
            {
                testbook2.add("2017UBT1001", 20, 20, 40, 2, 1);
                Assert.Fail("Invalid Values");
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correctly Caught Error");
            }
        }

        [Test]
        public void Test_findsum2()
        {
            try
            {
                testbook2.add("2017UCO1501", 10, 10, 10, 10, 10);
                testbook2.add("2017UCO1502", 10, 10, 20, 10, 10);
                testbook2.add("2017UCO1503", 10, 10, 30, 10, 10);
                testbook2.add("2017UCO1504", 10, 10, 40, 10, 10);
                double actualsum = testbook2.findSum();
                double expectedsum = 260.00;
                Assert.AreEqual(expectedsum, actualsum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_findAVG2()
        {
            try
            {
                testbook2.add("2017UCO1501", 10, 10, 10, 10, 10);
                testbook2.add("2017UCO1502", 10, 10, 20, 10, 10);
                testbook2.add("2017UCO1503", 10, 10, 30, 10, 10);
                testbook2.add("2017UCO1504", 10, 10, 40, 10, 10);
                double actualAVG = testbook2.findAVG();
                double expectedAVG = Math.Round((50.00 + 60 + 70 + 80) / 4, 2);
                Assert.AreEqual(expectedAVG, actualAVG, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test_findMIN2()
        {
            try
            {
                testbook2.add("2017UCO1501", 10, 10, 10, 10, 10);
                testbook2.add("2017UCO1502", 10, 10, 20, 10, 10);
                testbook2.add("2017UCO1503", 10, 10, 30, 10, 10);
                testbook2.add("2017UCO1504", 10, 10, 40, 10, 10);
                double actualMIN = testbook2.findMin();
                double expectedMIN = 50.00;
                Assert.AreEqual(expectedMIN, actualMIN, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_findMAX2()
        {
            try
            {
                testbook2.add("2017UCO1501", 10, 10, 10, 10, 10);
                testbook2.add("2017UCO1502", 10, 10, 20, 10, 10);
                testbook2.add("2017UCO1503", 10, 10, 30, 10, 10);
                testbook2.add("2017UCO1504", 10, 10, 40, 10, 10);
                double actualMAX = testbook2.findMax();
                double expectedMAX = 80.00;
                Assert.AreEqual(expectedMAX, actualMAX, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_UpdateStats2()
        {
            try
            {
                testbook2.add("2017UCO1501", 10, 10, 10, 10, 10);
                teststats = testbook2.stats;
                double actualavg = teststats.avg;
                double expectedavg = 50.00;
                Assert.AreEqual(expectedavg, actualavg);
                double actualmin = teststats.lowval;
                double expectedmin = 50.00;
                Assert.AreEqual(expectedmin, actualmin);
                double actualmax = teststats.highval;
                double expectedmax = 50.00;
                Assert.AreEqual(expectedmax, actualmax);

            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }


    }
}
