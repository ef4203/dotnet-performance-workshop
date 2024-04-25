namespace EFK.DotnetPerformanceWorkshop.Part1;

public sealed class Program
{
    public static int Main()
    {
        Examples.DiscreteSignalQuadratureAmplitudeModulation(in Examples.ExampleInput1);
        Examples.BinaryEuclideanGreatestCommonDenominator(1234567890, 987654321);

        return 0;
    }
}
