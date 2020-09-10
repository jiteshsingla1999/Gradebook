using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test_to_checkAVGcomputation()
        {
            var testbook = new Book();
            testbook.add("1618", 99.999);
            testbook.add("1583", 99.99);
            testbook.add("1585", 49.99);
            double actualAVG = testbook.findAVG();

            double expectedAVG = (99.999 + 99.99 + 49.99) / 3;

            Assert.AreEqual(expectedAVG, actualAVG, 0.01);
        }

        [Test]
        public void Test_to_checkStudentCount()
        {
            var testbook = new Book();
            testbook.add("1618", 99.999);
            testbook.add("1583", 99.99);
            testbook.add("1585", 49.99);

            double actualCount = testbook.count;

            double expectedCount = 3;

            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void Test_to_checkMaxcomputation()
        {
            var testbook = new Book();
            testbook.add("1618", 99.999);
            testbook.add("1583", 99.99);
            testbook.add("1585", 49.99);
            double actualmax = testbook.findMax();

            double expectedmax = Math.Round(99.999,2);

            Assert.AreEqual(expectedmax, actualmax, 0.001);
        }
    }
}
