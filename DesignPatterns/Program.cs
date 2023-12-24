﻿using System;
using DesignPatterns.Chapter1;
namespace DesignPatterns;
class Program
{
    static void Main(string[] args)
    {
        TestDuckClass();
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
    }
    
}

