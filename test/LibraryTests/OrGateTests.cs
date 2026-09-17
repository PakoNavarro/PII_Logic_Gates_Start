using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class OrGateTests
    {
        [Test] 
        public void Evaluate_BothTrue_ReturnsTrue()
        {
            OrGate gate = new OrGate(new LogicValue(true), new LogicValue(true));
            bool result = gate.Evaluate();
            Assert.That(result, Is.True);

        }

        [Test]
        public void Evaluate_FirstTrueSecondFalse_ReturnsTrue()
        {
            OrGate gate = new OrGate(new LogicValue(true), new LogicValue(false));
            bool result = gate.Evaluate();
            Assert.That(result, Is.True);
        }

        [Test]
        public void Evaluate_FirstFalseSecondTrue_ReturnsTrue()
        {
            OrGate gate = new OrGate(new LogicValue(false), new LogicValue(true));
            bool result = gate.Evaluate();
            Assert.That(result, Is.True);
        }

        [Test]
        public void Evaluate_BothFalse_ReturnsFalse()
        {
            OrGate gate = new OrGate(new LogicValue(false), new LogicValue(false));
            bool result = gate.Evaluate();
            Assert.That(result, Is.False);
        }
    }
}