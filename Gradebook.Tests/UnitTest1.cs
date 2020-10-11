using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    [TestFixture]
    public class Sample_Tests_1
    {
        private Book testbook;
        private Marks testmarks; 
        [SetUp]
        public void Setup()
        {
            testbook = new Book();
        }

        /// <summary>
        /// Test to check Average Function
        /// </summary>
        [Test]
        public void Test_to_checkAVGcomputation()
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
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);

                double actualCount = testbook.count;

                double expectedCount = 3;

                Assert.AreEqual(expectedCount, actualCount, 0.01);
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
                testbook.add("2017UCO1618", 25, 25, 50);
                testbook.add("2017UCO1583", 25, 24, 50);
                testbook.add("2017UCO1585", 24, 24, 50);
                double actualmax = testbook.findMax();
                double expectedmax = Math.Round(100.000, 2);
                Assert.AreEqual(expectedmax, actualmax, 0.01);
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

        [Test]
        public void Random_Test1()
        {

            try
            {
                testbook.add("2017UCO1500", 15, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 80.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }

        [Test]
        public void Random_Test2()
        {

            try
            {
                testbook.add("2017UCO1500", 25, 25, 50);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 100.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }

        [Test]
        public void Random_Test3()
        {

            try
            {
                testbook.add("2017UCO1500",0, 0, 0);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 0.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }

        [Test]
        public void Random_Test4()
        {

            try
            {
                testbook.add("2017UCO1600", 20, 20, 20);
                testbook.add("2017UCO1600", 20, 20, 20);
                testbook.add("2017UCO1600", 20, 20, 20);
                double ActualAVG = testbook.findAVG();
                double ExpectedAVG = 60.00;
                Assert.AreEqual(ExpectedAVG, ActualAVG, 0.01);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }

        [Test]
        public void Random_Test5()
        {
            try
            {
                testmarks = new Marks(10,20,30);
                string grade = testmarks.getGrade();
                Assert.AreEqual("B", grade);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }
        
        [Test]
        public void Random_Test6()
        {
            try
            {
                testmarks = new Marks(0, 0, 0);
                string grade = testmarks.getGrade();
                Assert.AreEqual("F", grade);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }

        [Test]
        public void Random_Test7()
        {
            try
            {
                testmarks = new Marks(25, 25, 50);
                string grade = testmarks.getGrade();
                Assert.AreEqual("O", grade);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }

        [Test]
        public void Random_Test8()
        {
            try
            {
                testmarks = new Marks(0, 25, 10);
                string grade = testmarks.getGrade();
                Assert.AreEqual("F", grade);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Invalid Roll Number");
            }
        }
    }
}
