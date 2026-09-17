using System;

public class OrGate : ILogicGate
{
    private ILogicGate input1;
    private ILogicGate input2;

    public OrGate(ILogicGate input1, ILogicGate input2)
    {
        this.input1 = input1;
        this.input2 = input2;
    }

    public bool Evaluate()
    {
        return this.input1.Evaluate() || this.input2.Evaluate();
    }
}