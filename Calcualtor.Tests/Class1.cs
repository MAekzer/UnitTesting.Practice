using NUnit.Framework;
using Calculator;

namespace Calcualtor.Tests
{
    [TestFixture]
    public class NUnitTests
    {
        Calc calculator = new();

        [Test]
        public void DivisionMustReturnCorrectNumber()
        {
            Assert.That(calculator.Division(15, 3) == 5);
            Assert.Throws<DivideByZeroException>(() => calculator.Division(2, 0));
        }

        [Test]
        public void AdditionMustReturnCorrectNumber()
        {
            Assert.That(calculator.Addition(15, 3) == 18);
        }

        [Test]
        public void SubtractionMustReturnCorrectNumber()
        {
            Assert.That(calculator.Subtraction(15, 3) == 12);
        }

        [Test]
        public void MultiplicationnMustReturnCorrectNumber()
        {
            Assert.That(calculator.Multiplication(15, 3) == 45);
        }
    }
}