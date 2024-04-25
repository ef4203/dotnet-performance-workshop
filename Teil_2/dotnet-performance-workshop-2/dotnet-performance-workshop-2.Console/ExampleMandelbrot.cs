namespace EFK.DotnetPerformanceWorkshop.Part2.Console;

public class ExampleMandelbrot
{
    private const double XMin = -2.0;

    private const double XMax = 1.0;

    private const double YMin = -1.0;

    private const double YMax = 1.0;

    private static void ToMath(int X, int Y, ref double x, ref double y, int width, int height)
    {
        if (X < 0 || X > width || Y < 0 || Y > height)
        {
            x = XMin;
            y = YMin;
            return;
        }

        x = XMin + X * (XMax - XMin) / width;
        y = YMin + (height - Y) * (YMax - YMin) / height;
    }

    private static int ComputeMandelbrot(
        double x,
        double y,
        double zx,
        double zy,
        int n,
        int nMax,
        double threshold)
    {
        if (n <= nMax && zx * zx + zy * zy < threshold)
        {
            var zxNew = zx * zx - zy * zy + x;
            var zyNew = 2 * zx * zy + y;
            if (zxNew == zx && zyNew == zy)
            {
                return nMax;
            }

            n = ComputeMandelbrot(x, y, zxNew, zyNew, n + 1, nMax, threshold);
        }

        return n;
    }

    public static int[,] Mandelbrot(int width, int height)
    {
        var data = new int[width, height];

        for (var i = 0; i < width; i++)
        {
            for (var j = 0; j < height; j++)
            {
                var x = 0.0;
                var y = 0.0;
                ToMath(i, j, ref x, ref y, width, height);
                var result = ComputeMandelbrot(x, y, 0.0, 0.0, 0, 500, 4.0);
                data[i, j] = result;
            }
        }

        return data;
    }
}
