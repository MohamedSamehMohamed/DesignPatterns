namespace DesignPatterns.Chapter3.BookDesign;

public class Decaf: Beverage
{
    public Decaf()
    {
        Description = "Decaf";
    }

    public override double Cost()
    {
        return 2.4;
    }
}