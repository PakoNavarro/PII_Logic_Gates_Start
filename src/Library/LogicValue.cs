using System;

public class LogicValue : ILogicGate
{
    public bool value{ get; }

    public LogicValue(bool value)
    {
        this.value = value;
    }
    
    public bool Evaluate()
    {
        return this.value;
    }
}
