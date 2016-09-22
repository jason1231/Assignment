namespace ItWorks.CL.Tests
{
    using System;
    using System.Text.RegularExpressions;

    using NUnit.Framework;

    [TestFixture]
    public class DocumentTests
    {
        [Test]
        public void QuickDocument_Test()
        {
            // Arrange
            var expectedValue = "name: content";
            var document = new QuickDocument { Name = "name", Content = "content" };

            // Act
            var results = document.PrintString();

            // Assert
            Assert.AreEqual(results, expectedValue);
        }

        [Test]
        public void StandardDocument_Test()
        {
            // Arrange
            var expectedValue = "name: content";
            var document = new StandardDocument { Name = "name", Content = "content", NumberOfCopies = 2 };

            // Act
            var results = document.PrintString();

            // Assert
            Assert.IsTrue(Regex.Matches(results, expectedValue).Count == document.NumberOfCopies);
        }

        [Test]
        public void SlowDocument_Test()
        {
            // Arrange
            var expectedValue = "name: content";
            var document = new SlowDocument { Name = "name", Content = "content", NumberOfCopies = 2 };

            // Act
            var startTime = DateTime.Now;

            var results = document.PrintString();

            var jobDuration = DateTime.Now - startTime;

            // Assert
            Assert.IsTrue(Regex.Matches(results, expectedValue).Count == document.NumberOfCopies);
            Assert.GreaterOrEqual(jobDuration, new TimeSpan(0, 0, document.Delay * document.NumberOfCopies));
        }
    }
}
