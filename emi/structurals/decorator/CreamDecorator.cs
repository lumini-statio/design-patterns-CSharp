namespace decorator;

public class CreamDecorator : AggregatedDecorator
{
    public CreamDecorator(Coffee coffee) : base(coffee)
    {
        AggregatedPrice = 300;
        Cream = true;
    }
}
