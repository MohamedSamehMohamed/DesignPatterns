namespace DesignPatterns.Chapter3.BookDesign;

public class Sugar: Condiment
{
    public Sugar(Beverage beverage): base(beverage)
    {
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() +  ", sugar";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 1.2;
    }
}