// See https://aka.ms/new-console-template for more information

using UnitTestingLearn.Calculators;

Console.WriteLine(new BrokenCalculator().Add(10, 10));
Console.WriteLine(new BrokenCalculator().Subtract(10, 5));