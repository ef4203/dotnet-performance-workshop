namespace EFK.DotnetPerformanceWorkshop.Part2.Tests;

using EFK.DotnetPerformanceWorkshop.Part2.Console;
using FluentAssertions;
using NUnit.Framework;

public class FibonacciTest
{
    [TestCase(0, 0)]
    [TestCase(-1, 0)]
    [TestCase(-2, 0)]
    [TestCase(int.MinValue, 0)]
    [TestCase(1, 1)]
    [TestCase(4, 3)]
    [TestCase(51, 20365011074L)]
    [TestCase(7, 13)]
    [TestCase(13, 233)]
    public void ExampleFibonacci_Fibonacci_WithBaseCases(int n, long expected)
    {
        var result = ExampleFibonacci.Fibonacci(n);

        // Assert
        result
            .Should()
            .Be(expected);
    }
}
