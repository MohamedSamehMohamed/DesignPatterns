using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Chapter3.BookDesign;

public abstract class Beverage
{
    protected string Description { get; set; } = "Unknown Beverage";

    public virtual string GetDescription()
    {
        return Description;
    }
    public abstract double Cost();
}