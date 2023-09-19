using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    [TestFixture]
    public class ClassTests
    {
        [Test]
        public void TestClassName()
        {
            // Arrange
            Class myClass = new Class();
            myClass.Name = "Maths";

            // Act
            string className = myClass.Name;

            // Assert
            Assert.AreEqual("Maths", className);
        }

        [Test]
        public void TestClassId()
        {
            // Arrange
            Class myClass = new Class();
            myClass.Id = 1;

            // Act
            int classId = myClass.Id;

            // Assert
            Assert.AreEqual(1, classId);
        }
    }
}
