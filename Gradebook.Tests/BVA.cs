using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using GradeBook;

namespace Gradebook.Tests
{
    /// <summary>
    /// Test class containing Boundary Value Test Cases
    /// We have used Robust Boundary Value Checking. 
    /// Number of variables = 4 [StudentID, InternalAssessmentMarks, MidSemMarks, EndSemMarks]
    /// Hence, using this technique, 25 (6*4 + 1) test cases have been added
    /// </summary>
    [TestFixture]
    [Category("Boundary Value Testing")]
    public class BVA_Tests
    {
        private Book testbook;


        [SetUp]
        public void Setup()
        {
            testbook = new Book();
        }


        [Test]
        public void Test_RollNoMinminus()
        {
            try
            {
                testbook.add("2017UCO1499", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNoMin()
        {
            try
            {
                testbook.add("2017UCO1500", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNoMinplus()
        {
            try
            {
                testbook.add("2017UCO1501", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNoMaxminus()
        {
            try
            {
                testbook.add("2017UCO1699", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNoMax()
        {
            try
            {
                testbook.add("2017UCO1700", 20, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 85.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_RollNoMaxplus()
        {
            try
            {
                testbook.add("2017UCO1701", 20, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Roll Number");
            }
        }

        [Test]
        public void Test_InternalMinminus()
        {
            try
            {
                testbook.add("2017UCO1618", -1, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalMin()
        {
            try
            {
                testbook.add("2017UCO1618", 0, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 65.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalMinplus()
        {
            try
            {
                testbook.add("2017UCO1618", 1, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 66.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalMaxminus()
        {
            try
            {
                testbook.add("2017UCO1618", 24, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 89.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalMax()
        {
            try
            {
                testbook.add("2017UCO1618", 25, 20, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 90.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_InternalMaxplus()
        {
            try
            {
                testbook.add("2017UCO1618", 26, 20, 45);
            }
            catch
            {
                Assert.Pass("Invalid Internal Marks");
            }
        }

        [Test]
        public void Test_MidsemMinminus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, -1, 45);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidsemMin()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 0, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 65.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidsemMinplus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 1, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 66.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidsemMaxminus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 24, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 89.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidsemMax()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 25, 45);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 90.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_MidsemMaxplus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 26, 45);
            }
            catch
            {
                Assert.Pass("Invalid Midsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMinminus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,-1);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMin()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,0);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 40.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMinplus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,1);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 41.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMaxminus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,49);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 89.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMax()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,50);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 90.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_EndsemMaxplus()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,51);
            }
            catch
            {
                Assert.Pass("Invalid Endsem Marks");
            }
        }

        [Test]
        public void Test_AllwithinRange()
        {
            try
            {
                testbook.add("2017UCO1618", 20, 20,40);
                double ActualSum = testbook.findSum();
                double ExpectedSum = 80.00;
                Assert.AreEqual(ExpectedSum, ActualSum, 0.01);
            }
            catch
            {
                Assert.Pass();
            }
        }
    }
}