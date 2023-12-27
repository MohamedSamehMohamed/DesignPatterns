namespace DesignPatterns.Chapter3.BookDesign;

public class Espresso: Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    public override double Cost()
    {
        return 1.7;
    }
}