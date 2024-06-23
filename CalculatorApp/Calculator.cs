using System;
using System.Collections.Generic;

public class Calculator
{
    Dictionary<string, ICalculator> operations = new Dictionary<string, ICalculator>();
    public Calculator()
    {
        operations.Add("+",new Add());
        operations.Add("-",new Subtract());
        operations.Add("*",new Multiply());
        operations.Add("/",new Divide());
    }


    public double Execute(String op, double val1, double val2)
    {
        if(operations.ContainsKey(op))
        {
            return operations[op].Calculate(val1,val2);
        }
        else return 0;
    }
}