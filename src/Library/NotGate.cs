using System;

public class NotGate : ILogicGate
{
    private ILogicGate input;

    public NotGate(ILogicGate input)
    {
        this.input = input;
    }

    public bool Evaluate()
    {
        return !this.input.Evaluate();
    }

}