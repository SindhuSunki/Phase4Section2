using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    [TestFixture]
    public class SubjectTests
    {
        [Test]
        public void TestSubName()
        {
            // Arrange
            Subject sub = new Subject();
            sub.Name = "English";

            // Act
            string subName = sub.Name;

            // Assert
            Assert.AreEqual("English", subName);
        }

        [Test]
        public void TestSubId()
        {
            // Arrange
            Subject sub = new Subject();
            sub.Id = 2;

            // Act
            int subId = sub.Id;

            // Assert
            Assert.AreEqual(2, subId);
        }
    }
}
