using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator;
using NumericSequenceCalculator.Controllers;

namespace NumericSequenceCalculator.Tests.Controllers
{
    [TestClass]
    public class SequenceControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            IEnumerable<int> result = controller.GetSequence(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(11, result.Count());
            Assert.AreEqual(2, result.ElementAt(2));
            Assert.AreEqual(3, result.ElementAt(3));
        }

        [TestMethod]
        public void GetEvenSequence()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            IEnumerable<int> result = controller.GetEvenSequence(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count());
            Assert.AreEqual(4, result.ElementAt(2));
            Assert.AreEqual(8, result.ElementAt(4));
        }

        [TestMethod]
        public void GetOddSequence()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            IEnumerable<int> result = controller.GetOddSequence(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual(5, result.ElementAt(2));
            Assert.AreEqual(9, result.ElementAt(4));
        }


        [TestMethod]
        public void GetConditionalSequence_5()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            var result = controller.GetConditionalSequence(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("E", result);
        }

        [TestMethod]
        public void GetConditionalSequence_3()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            var result = controller.GetConditionalSequence(9);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void GetConditionalSequence_3_And_5()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            var result = controller.GetConditionalSequence(15);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Z", result);
        }

        [TestMethod]
        public void GetFibonacciSequence()
        {
            // Arrange
            SequenceController controller = new SequenceController();

            // Act
            IEnumerable<int> result = controller.GetFibonacciSequence(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Count());

            Assert.AreEqual(1, result.ElementAt(2));
            Assert.AreEqual(2, result.ElementAt(3));
            Assert.AreEqual(5, result.ElementAt(5));
        }
    }
}
