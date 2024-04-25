namespace EFK.DotnetPerformanceWorkshop.Part2.Console;

using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

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
}
