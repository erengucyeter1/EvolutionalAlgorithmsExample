using EvolutionalAlgorithmsExample.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolutionalAlgorithmsExample.Tests.Core
{
    [TestClass]
    public class GenomeTests
    {
        [TestMethod]
        public void ToDecimal_ShouldReturnCorrectDecimalValue()
        {
            // Arrange
            bool[] nucleotides = new bool[] { true, false, false, false, true, false, false, true }; // Binary: 1101
            int floatingPointLocation = 3;
            Genomev0 genome = new Genomev0(nucleotides, floatingPointLocation);

            // Act
            decimal result = genome.ToDecimal();

            // Assert
            Assert.AreEqual(18.125m, result); // Binary 1101 with floating point at 2 is 6.5 in decimal
        }

        [TestMethod]
        public void ToDecimal_ShouldReturnZeroForAllFalseNucleotides()
        {
            // Arrange
            bool[] nucleotides = new bool[] { false, false, false, false };
            int floatingPointLocation = 2;
            Genomev0 genome = new Genomev0(nucleotides, floatingPointLocation);

            // Act
            decimal result = genome.ToDecimal();

            // Assert
            Assert.AreEqual(0m, result);
        }

        [TestMethod]
        public void ToDecimal_ShouldHandleFloatingPointAtStart()
        {
            // Arrange
            bool[] nucleotides = new bool[] { true, true, false, true }; // Binary: 1011
            int floatingPointLocation = 0;
            Genomev0 genome = new Genomev0(nucleotides, floatingPointLocation);

            // Act
            decimal result = genome.ToDecimal();

            // Assert
            Assert.AreEqual(11m, result); // Binary 1011 with floating point at 0 is 11 in decimal
        }
    }
}
