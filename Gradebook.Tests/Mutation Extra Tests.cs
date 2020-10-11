using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    [TestFixture]
    [Category("Mutation testing Extra Tests")]
    public class Extra_Tests
    {
        private Book1 testbook;
        private Marks testmarks; 
        [SetUp]
        public void Setup()
        {
            testbook = new Book1();
        }

        [Test]
        public void Test1()
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
            catch (ArgumentException e)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test2()
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
        public void Test3()
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
        public void Test4()
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
        public void Test5()
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

        [Test]
        public void Test6()
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
        public void Test7()
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
        public void Test8()
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
        public void Test9()
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
    }
}
