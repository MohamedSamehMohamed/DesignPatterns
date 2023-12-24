using System;
using DesignPatterns.Chapter1.FlyBehavior;
using DesignPatterns.Chapter1.QuackBehavior;

namespace DesignPatterns.Chapter1;

public class MallardDuck: Duck
{
    public MallardDuck()
    {
        _flyBehaviour = new FlyWithWings();
        _quackBehavior = new SimpleQuack();
    }

    public override void Display()
    {
        Console.WriteLine("this is mallard duck");
    }
}