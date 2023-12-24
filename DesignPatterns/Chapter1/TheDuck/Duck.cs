using System;

namespace DesignPatterns.Chapter1;
public abstract class Duck
{
    protected IFly _flyBehaviour;
    protected IQuack _quackBehavior;
    public void Fly()
    {
        _flyBehaviour.Fly();
    }

    public void Quack()
    {
        _quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("swim");
    }

    public void SetFlyBehaviour(IFly flyBehaviour)
    {
        _flyBehaviour = flyBehaviour;
    }

    public void SetQuackBehavior(IQuack quackBehaviour)
    {
        _quackBehavior = quackBehaviour;
    }
    public abstract void Display();
}
