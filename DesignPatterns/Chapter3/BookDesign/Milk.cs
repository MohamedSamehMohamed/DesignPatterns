namespace DesignPatterns.Chapter3.BookDesign;

public class Milk: Condiment
{
    public Milk(Beverage beverage): base(beverage)
    {
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() +  ", milk";
    }

    public override double Cost()
    {
        return _beverage.Cost() +  1.2;
    }
}