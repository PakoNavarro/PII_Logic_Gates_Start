using System;

public class AndGate : ILogicGate   
{
    private ILogicGate input1;
    private ILogicGate input2;

    public AndGate(ILogicGate input1, ILogicGate input2)
    {
        this.input1 = input1;
        this.input2 = input2;
    }
    
    public bool Evaluate()
    {
        return this.input1.Evaluate() && this.input2.Evaluate();
    }
}