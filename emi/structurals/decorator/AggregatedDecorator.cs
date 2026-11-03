namespace decorator;
public class AggregatedDecorator : Coffee
{
    private readonly Coffee _coffee;
    private double _aggregatedPrice;

    public double AggregatedPrice
    {
        get { return _aggregatedPrice; }
        set { _aggregatedPrice = value; }
    }

    public AggregatedDecorator(Coffee coffee) : base(coffee.Type)
    {
        _coffee = coffee;
        Cream = coffee.Cream;
        Milk = coffee.Milk;
        Chocolates = coffee.Chocolates;
    }

    public override double MakeOrder()
    {
        return _coffee.MakeOrder() + AggregatedPrice;
    }
}
