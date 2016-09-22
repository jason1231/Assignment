namespace ItWorks.CL.Tests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class MethodTests
    {
        [Test]
        public void Method_1_Test()
        {
            //Arrange
            var expectedValue = new List<int> { 7, 14, 21, 28, 35, 42, 49 };

            //Act
            var results = Methods.Method1(50);

            //Assert
            Assert.AreEqual(expectedValue, results);
        }

        [Test]
        public void Method_2_Test()
        {
            //Arrange
            var expectedValue = new List<int> { 7, 14, 21, 28, 35, 42, 49 };

            //Act
            var results = Methods.Method1(50);

            //Assert
            Assert.AreEqual(expectedValue, results);
        }

        [Test]
        public void Method_3_Test()
        {
            //Arrange
            var expectedValue = "neerg";

            //Act
            var results = Methods.Method3("green");

            //Assert
            Assert.AreEqual(expectedValue, results);
        }
    }
}