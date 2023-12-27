using System;
using DesignPatterns.Chapter1;
using DesignPatterns.Chapter1.FlyBehavior;
using DesignPatterns.Chapter2;
using DesignPatterns.Chapter3.BookDesign.Test;
using DesignPatterns.Chapter3.MyDesign;
namespace DesignPatterns;
class Program
{
    static void Main(string[] args)
    {
        TestDecoratePatternBookDesign();
    }
    private static void TestDecoratePatternBookDesign()
    {
        Test.TestBookDesign();
    }
    private static void TestDecoratePatternMyDesign()
    {
        var espresso = new Espresso();
        var decaf = new Decaf();
        espresso.AddCondiment(new Soy(2.3));
        espresso.AddCondiment(new Milk(2.3));
        decaf.AddCondiment(new Sugar(5));
        Console.WriteLine(espresso.GetDescription() + " " + espresso.Cost());
        Console.WriteLine(decaf.GetDescription() + " " + decaf.Cost());
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

