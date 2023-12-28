namespace DesignPatterns.Chapter4;

public class ChicagoStylePizzaStore: PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type == "ChicagoCheese")
        {
            return new CheesePizza();
        }else if (type == "ChicagoClam")
        {
            return new ClamPizza();
        }

        return null;
    }
}