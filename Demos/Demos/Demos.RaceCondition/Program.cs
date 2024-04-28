namespace Demos.RaceCondition;

public class Program
{
    private static int counter = 0;

    public static void Main(string[] args)
    {
        var thread1 = new Thread(IncrementCounter);
        var thread2 = new Thread(IncrementCounter);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Final counter value: " + counter);
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 1000000; i++)
        {
            counter++;
        }
    }
}
