using NUnit.Framework;
using Project_2;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace UnitTestProject1
{
    [TestFixture]
    public class SubjectTest
    {
        [Test]
        public void TestSubjectId()
        {
            Subject subject = new Subject();
            subject.SubjectId = 1;
            int subjectId = subject.SubjectId;
            Assert.AreEqual(1, subjectId);
        }
        [Test]
        public void TestSubjectName()
        {
            Subject subject = new Subject();
            subject.SubjectName = "English";
            string subjectName = subject.SubjectName;
            Assert.AreEqual("English", subjectName);
        }
    }
}