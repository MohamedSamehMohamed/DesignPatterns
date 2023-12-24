namespace DesignPatterns.Chapter1;
public abstract class Duck
{
    protected IFly _flyBehaviour;
    protected IQuack _quackBehavior;
    public void Fly()
    {
        _flyBehaviour.Fly();
    }

    public void Quack()
    {
        _quackBehavior.Quack();
    }
    public abstract void  Swim();
    public abstract void Display();
}
