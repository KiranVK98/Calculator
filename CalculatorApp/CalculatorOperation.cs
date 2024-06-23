// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Add() : ICalculator
{
    public double Calculate(double a, double b)
    {
        return a+b;
    }
}

public class Subtract() : ICalculator
{
    public double Calculate(double a, double b)
    {
        return a-b;
    }
}

public class Multiply() : ICalculator
{
    public double Calculate(double a, double b)
    {
        return a*b;
    }
}

public class Divide() : ICalculator
{
    public double Calculate(double a, double b)
    {
        return a/b;
    }
}
