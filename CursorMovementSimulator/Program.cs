using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
class Program
{
    static void Main() 
    {
        Console.WriteLine("Simulation....");
        Console.WriteLine("Simulation....");
        Console.WriteLine("Simulation....");
        Console.WriteLine("Simulation....");
        Console.WriteLine("Simulation....");
        Console.WriteLine("Simulation....");

        SimulateCursorMovement();
    }

    static void SimulateCursorMovement()
    {
        var inputSimulator = new InputSimulator();
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            int x = random.Next(1920); 
            int y = random.Next(1080);

            inputSimulator.Mouse.MoveMouseTo(x, y);

            Thread.Sleep(random.Next(50, 200));
        }
    }
}