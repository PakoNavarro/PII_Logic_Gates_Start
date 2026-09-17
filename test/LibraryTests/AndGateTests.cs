using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class AndGateTests
    {
        [Test]
        public void Evaluate_BothTrue_ReturnsTrue()
        {
            AndGate gate = new AndGate(new LogicValue(true), new LogicValue(true));
            bool result = gate.Evaluate();
            Assert.That(result, Is.True);
        }

        [Test]
        public void Evaluate_FirstTrueSecondFalse_ReturnsFalse()
        {
            AndGate gate = new AndGate(new LogicValue(true), new LogicValue(false));
            bool result = gate.Evaluate();
            Assert.That(result, Is.False);
        }

        [Test]
        public void Evaluate_FirstFalseSecondTrue_ReturnsFalse()
        {
            AndGate gate = new AndGate(new LogicValue(false), new LogicValue(true));
            bool result = gate.Evaluate();
            Assert.That(result, Is.False);
        }

        [Test]
        public void Evaluate_BothFalse_ReturnsFalse()
        {
            AndGate gate = new AndGate(new LogicValue(false), new LogicValue(false));
            bool result = gate.Evaluate();
            Assert.That(result, Is.False);
        }
    }
}