using System;

namespace DesignPatterns.Chapter1.FlyBehavior;

public class FlyNoWay: IFly
{
    public void Fly()
    {
        Console.WriteLine("Fly no way");
    }
}