using System;

namespace DesignPatterns.Chapter4;

public class Testing
{
    public static void Test()
    {
        NYStylePizzaStore nyStylePizzaStore = new NYStylePizzaStore();
        ChicagoStylePizzaStore chicagoStylePizzaStore = new ChicagoStylePizzaStore();
        var pizzaCheese = nyStylePizzaStore.OrderPizza("Cheese");
        var pizzaClam = chicagoStylePizzaStore.OrderPizza("ChicagoClam");
        Console.WriteLine(pizzaCheese.Name);
        Console.WriteLine(pizzaClam.Name);
    }
}