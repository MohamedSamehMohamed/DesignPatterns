using System;

namespace DesignPatterns.Chapter1.QuackBehavior;

public class Squack: IQuack
{
    public void Quack()
    {
        Console.WriteLine("squack");
    }
}