namespace EFK.DotnetPerformanceWorkshop.Part1;

public class Examples
{
    public static readonly double[] ExampleInput1 = [1.23, 3.141, 23.1, 29.3, 17.01, 4.23, 5.13, 6.132, 9.34];

    public static double[] DiscreteSignalQuadratureAmplitudeModulation(double[] inputSignal)
    {
        var resultLen = inputSignal.Length / 2 + inputSignal.Length % 2;
        var result = new double[resultLen];

        for (var i = 0; i < inputSignal.Length; i++)
        {
            result[i / 2] += i % 2 == 0
                ? inputSignal[i] * Math.Cos(Math.Floor(i / 2.0) * 0.1)
                : inputSignal[i] * Math.Sin(Math.Floor(i / 2.0) * 0.1);
        }

        return result;
    }

    public static uint BinaryEuclideanGreatestCommonDenominator(uint a, uint b)
    {
        if (a == 0)
        {
            return b;
        }

        if (b == 0)
        {
            return a;
        }

        var d = 0u;
        while (a % 2 == 0 && b % 2 == 0)
        {
            a /= 2;
            b /= 2;
            d++;
        }

        while (a % 2 == 0)
        {
            a /= 2;
        }

        while (b % 2 == 0)
        {
            b /= 2;
        }

        while (a != b)
        {
            if (a > b)
            {
                a -= b;
                while (a % 2 == 0)
                {
                    a /= 2;
                }
            }
            else
            {
                b -= a;
                while (b % 2 == 0)
                {
                    b /= 2;
                }
            }
        }

        return (uint)Math.Pow(2, d) * a;
    }
}
