using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Project_2;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            Student student = new Student();
            student.StudentName = "Rohithkumar";
            string studentName = student.StudentName;
            Assert.AreEqual("Rohithkumar", studentName);
        }
        [Test]
        public void TestStudentClass()
        {
            Student student = new Student();
            student.Class = 12;
            int studentClass = student.Class;
            Assert.AreEqual(12, studentClass);
        }
        [Test]
        public void TestStudentSection()
        {
            Student student = new Student();
            student.Section = 'B';
            char studentSection = student.Section;
            Assert.AreEqual('B', studentSection);
        }
    }
}