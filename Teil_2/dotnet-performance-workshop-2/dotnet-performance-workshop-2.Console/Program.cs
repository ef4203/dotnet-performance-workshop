namespace EFK.DotnetPerformanceWorkshop.Part2.Console;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<Program>();
    }

    [Benchmark]
    public void Mandelbrot_Original()
    {
        ExampleMandelbrotOriginal.Mandelbrot(1000, 1000);
    }

    [Benchmark]
    public void Mandelbrot()
    {
        ExampleMandelbrot.Mandelbrot(1000, 1000);
    }

    [Benchmark]
    public void Easy()
    {
        ExampleEasy.TopData(ExampleEasy.ExampleInput);
    }

    [Benchmark]
    public void Easy_Original()
    {
        ExampleEasyOriginal.TopData(ExampleEasyOriginal.ExampleInput);
    }

    [Benchmark]
    public void Fibonacci()
    {
        ExampleFibonacci.Fibonacci(4);
        ExampleFibonacci.Fibonacci(7);
        ExampleFibonacci.Fibonacci(13);
    }

    [Benchmark]
    public void Fibonacci_Original()
    {
        ExampleFibonacciOriginal.Fibonacci(4);
        ExampleFibonacciOriginal.Fibonacci(7);
        ExampleFibonacciOriginal.Fibonacci(13);
    }
}
