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
        private Book2 testbook2;

        Marks testmarks1;
        PracticalMarks testmarks2;

        [SetUp]
        public void Setup()
        {
            // Runs before each test executes
            testbook1 = new Book1();
            testbook2 = new Book2();


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


        public void Test_Marks_with_Prac()
        {
            try
            {
                testmarks2 = new PracticalMarks();
                string actualName = testmarks2.classInfo();
                string expectedName = "This is Marks with Practical";
                Assert.AreEqual(expectedName, actualName);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

        [Test]
        public void Test_Marks_without_Prac()
        {
            try
            {
                testmarks1 = new Marks();
                string actualName = testmarks1.classInfo();
                string expectedName = "This is Marks without Practical";
                Assert.AreEqual(expectedName, actualName);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Something Went Wrong");
            }
        }

    }
}
