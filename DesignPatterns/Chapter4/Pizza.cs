using System;

namespace DesignPatterns.Chapter4;

public class Pizza
{
    public string Name;
    public void Prepare()
    {
        Console.WriteLine("prepare");
    }

    public void Bake()
    {
        Console.WriteLine("back");
    }

    public void Cut()
    {
        Console.WriteLine("cut");
    }

    public void box()
    {
        Console.WriteLine("box");
    }
}