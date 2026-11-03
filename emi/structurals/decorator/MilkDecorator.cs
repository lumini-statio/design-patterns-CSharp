namespace decorator;

public class MilkDecorator : AggregatedDecorator
{
    public MilkDecorator(Coffee coffee) : base(coffee)
    {
        AggregatedPrice = 400;
        Milk = true;
    }
}
