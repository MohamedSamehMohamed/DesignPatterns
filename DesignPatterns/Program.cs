using System;
using DesignPatterns.Chapter1;
using DesignPatterns.Chapter1.FlyBehavior;
using DesignPatterns.Chapter2;

namespace DesignPatterns;
class Program
{
    static void Main(string[] args)
    {
        TestObserverPattern();
    }

    private static void TestObserverPattern()
    {
        ISubject subject = new Subject();
        var observer = new Observer();
        subject.AddObserver(observer);
        subject.UpdateSubjectData(new SubjectData("1", "2"));
        observer.Display();
    }
    private static void TestDuckClass()
    {
        var redHeadDuck = new RedHeadDuck();
        var mallardDuck = new MallardDuck();
        
        redHeadDuck.Display();
        mallardDuck.Display();
        Console.WriteLine();
        
        redHeadDuck.Swim();
        mallardDuck.Swim();
        Console.WriteLine();
        
        redHeadDuck.Fly();
        mallardDuck.Fly();
        Console.WriteLine();
        
        redHeadDuck.Quack();
        mallardDuck.Quack();
        Console.WriteLine();
        
        Console.WriteLine("change fly behavior");
        redHeadDuck.SetFlyBehaviour(new FlyWithWings());
        redHeadDuck.Fly();
    }
    
}

