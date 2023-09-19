using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentId()
        {
            // Arrange
            Student student = new Student();
            student.Id = 1;

            // Act
            int studentId = student.Id;

            // Assert
            Assert.AreEqual(1, studentId);
        }
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Sam";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Sam", studentName);
        }

        [Test]
        public void TestStudentClass()
        {
            // Arrange
            Student student = new Student();
            student.Class = 5;

            // Act
            int studentClass = student.Class;

            // Assert
            Assert.AreEqual(5, studentClass);
        }



    }
}
