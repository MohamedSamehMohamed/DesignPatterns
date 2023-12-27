namespace DesignPatterns.Chapter3.BookDesign;

public abstract class Condiment: Beverage
{
    protected Beverage _beverage;

    public Condiment(Beverage beverage)
    {
        _beverage = beverage;
    }
    public abstract override string GetDescription();
}