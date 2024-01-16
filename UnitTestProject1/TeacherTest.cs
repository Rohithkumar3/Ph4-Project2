using NUnit.Framework;
using Project_2;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace UnitTestProject1
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void TestTeacherId()
        {
            var teacher = new Teacher();
            teacher.TeacherId = 10;
            Assert.AreEqual(10, teacher.TeacherId);
        }
        [Test]
        public void TestTeacherName()
        {
            var teacher = new Teacher();
            teacher.TeacherName = "Kumari";
            Assert.AreEqual("Kumari", teacher.TeacherName);
        }
    }
}