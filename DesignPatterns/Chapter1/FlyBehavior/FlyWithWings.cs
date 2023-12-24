using System;

namespace DesignPatterns.Chapter1.FlyBehavior;

public class FlyWithWings: IFly
{
    public void Fly()
    {
        Console.WriteLine("fly with wings");
    }
}