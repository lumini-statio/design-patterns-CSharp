namespace decorator;

public class ChocolateDecorator : AggregatedDecorator
{
    public ChocolateDecorator(Coffee coffee) : base(coffee)
    {
        AggregatedPrice = 500;
        Chocolates++;
    }
}
