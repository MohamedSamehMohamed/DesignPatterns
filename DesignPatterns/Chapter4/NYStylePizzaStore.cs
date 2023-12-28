namespace DesignPatterns.Chapter4;

public class NYStylePizzaStore: PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type == "Cheese")
        {
            return new CheesePizza();
        }else if (type == "Clam")
        {
            return new ClamPizza();
        }
        return null;
    }
}