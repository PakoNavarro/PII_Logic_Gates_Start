using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class NotGateTests
    {
        [Test]
        public void Evaluate_InputTrue_ReturnsFalse()
        {
            NotGate gate = new NotGate(new LogicValue(true));
            bool result = gate.Evaluate();
            Assert.That(result, Is.False);
        }

        [Test]
        public void Evaluate_InputFalse_ReturnsTrue()
        {
            NotGate gate = new NotGate(new LogicValue(false));
            bool result = gate.Evaluate();
            Assert.That(result, Is.True);
        }
    }
}   


