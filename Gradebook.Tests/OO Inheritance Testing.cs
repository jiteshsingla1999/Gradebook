using NUnit.Framework;
using GradeBook;
using System;

namespace Gradebook.Tests
{
    [TestFixture]
    [Category("Object Oriented Tests")]
    public class OO_Inheritance_testing
    {
        private Book1 testbook1;
        [SetUp]
        public void Setup()
        {
            // Runs before each test executes
            testbook1 = new Book1();
        }

        [Test]
        public void Test_CourseNameChild()
        {
            try
            {
                string actualName = testbook1.getCourseName();
                string expectedName = "Software Testing";
                Assert.AreEqual(expectedName, actualName);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_CourseNameParent()
        {
            try
            {
                string actualName = testbook1.getParentCourseName();
                string expectedName = "This is the Base Course";
                Assert.AreEqual(expectedName, actualName);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }
    }
}
