using System;

namespace DesignPatterns.Chapter3.BookDesign.Test;

public class Test
{
    public static void TestBookDesign()
    {
        Beverage espresso = new Espresso();
        Beverage decaf = new Decaf();
        espresso = new Milk(espresso);
        espresso = new Soy(espresso);
        decaf = new Sugar(decaf);
        Console.WriteLine(espresso.GetDescription() + " " + espresso.Cost());
        Console.WriteLine(decaf.GetDescription() + " " + decaf.Cost());
    }
}