using System;

namespace DesignPatterns.Chapter1.QuackBehavior;

public class SimpleQuack: IQuack
{
    public void Quack()
    {
        Console.WriteLine("quack");
    }
}