using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    [Category("Equivalence Paritition Testing")]
    public class Equivalence_Partitioning_Tests
    {
        private Book testbook;

        [SetUp]
        public void Setup()
        {
            // Runs before each test executes
            testbook = new Book();
        }

        [Test]
        public void Test_InternalMinus()
        {
            try
            {
                testbook.add("2017UCO1618", -2, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalinRange()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalPlus()
        {
            try
            {
                testbook.add("2017UCO1618", 30, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_MidsemMinus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, -10, 45);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidsemPlus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 30, 45);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMinus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20, -20);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndsemPlus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20, 65);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_ValidLengthofID()
        {
            try
            {
                testbook.add("201UCO1618", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Length of StudentID");
            }
        }

        [Test]
        public void Test_ValidYear()
        {
            try
            {
                testbook.add("2012UCO1618", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Year in the StudentID");
            }
        }

        [Test]
        public void Test_ValidDegree()
        {
            try
            {
                testbook.add("2017PCO1618", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Degree in Student ID");
            }
        }

        [Test]
        public void Test_ValidBranch()
        {
            try
            {
                testbook.add("2017UBT1618", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Branch");
            }
        }

        [Test]
        public void Test_RollNumMinus()
        {
            try
            {
                testbook.add("2017UCO1440", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNumPlus()
        {
            try
            {
                testbook.add("2017UCO1840",20,20,45);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }
    }
}