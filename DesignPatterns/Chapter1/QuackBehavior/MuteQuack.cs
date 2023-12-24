using System;

namespace DesignPatterns.Chapter1.QuackBehavior;

public class MuteQuack: IQuack
{
    public void Quack()
    {
        Console.WriteLine("mute quack");
    }
}