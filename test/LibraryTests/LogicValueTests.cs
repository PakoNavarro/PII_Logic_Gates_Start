using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class LogicValueTests
    {
        [Test]
        public void Evaluate_TrueValue_ReturnsTrue()
        {
            LogicValue value = new LogicValue(true);

            bool result = value.Evaluate();

            Assert.That(result, Is.True);
        }

        [Test]
        public void Evaluate_FalseValue_ReturnsFalse()
        {
            LogicValue value = new LogicValue(false);

            bool result = value.Evaluate();

            Assert.That(result, Is.False);
        }
    }
}