namespace DesignPatterns.Chapter3.BookDesign;

public class Soy: Condiment
{
    public Soy(Beverage beverage): base(beverage)
    {
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", soy";
    }

    public override double Cost()
    {
        return _beverage.Cost() +  1.2;
    }
}