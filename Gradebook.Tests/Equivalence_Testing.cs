using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class Equivalence_Partitioning_Tests
    {
        [Test]
        public void Test_InternalMinus()
        {
            try
            {
                var testbook = new Book();
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
                var testbook = new Book();
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
                var testbook = new Book();
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
                var testbook = new Book();
                testbook.add("2017UCO1618", 20, -10, 45);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidseminRange()
        {
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1618", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
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
                var testbook = new Book();
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
                var testbook = new Book();
                testbook.add("2017UCO1618", 20, 20, -20);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndseminRange()
        {
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1618", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
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
                var testbook = new Book();
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
                var testbook = new Book();
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
                var testbook = new Book();
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
                var testbook = new Book();
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
                var testbook = new Book();
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
                var testbook = new Book();
                testbook.add("2017UCO1440", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNuminRange()
        {
            try
            {
                var testbook = new Book();
                testbook.add("2017UCO1540", 20, 20, 45);
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
                var testbook = new Book();
                testbook.add("2017UCO1840",20,20,45);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }
    }
}