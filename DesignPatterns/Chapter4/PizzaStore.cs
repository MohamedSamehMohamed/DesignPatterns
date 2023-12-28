namespace DesignPatterns.Chapter4;

public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.box();
        return pizza;
    }

    protected abstract Pizza CreatePizza(string type);
}