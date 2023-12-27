namespace DesignPatterns.Chapter3.MyDesign;

public abstract class Condiment
{
    protected double _cost;
    protected string _description;
    public double Cost()
    {
        return _cost;
    }

    public string GetDescription()
    {
        return _description;
    }
}