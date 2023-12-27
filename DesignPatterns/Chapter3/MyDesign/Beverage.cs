using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Chapter3.MyDesign;

public abstract class Beverage
{
    protected string Description { get; set; }
    protected double BeverageCost { get; init; }
    private readonly List<Condiment> _condiments = new();

    public string GetDescription()
    {
        var description = Description + "\n";
        foreach (var condiment in _condiments)
            description += condiment.GetDescription() + "\n";
        return description;
    }

    public void AddCondiment(Condiment condiment)
    {
        _condiments.Add(condiment);
    }
    public double Cost()
    {
        var condimentsCost = _condiments.Sum(condiment => condiment.Cost());
        return condimentsCost + BeverageCost;
    }
}