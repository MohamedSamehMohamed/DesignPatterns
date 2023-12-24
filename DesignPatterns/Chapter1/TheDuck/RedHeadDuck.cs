using System;
using DesignPatterns.Chapter1.FlyBehavior;
using DesignPatterns.Chapter1.QuackBehavior;

namespace DesignPatterns.Chapter1;

public class RedHeadDuck: Duck
{
    public RedHeadDuck()
    {
        _flyBehaviour = new FlyNoWay();
        _quackBehavior = new MuteQuack();
    }

    public override void Display()
    {
        Console.WriteLine("this is red head duck");
    }
}