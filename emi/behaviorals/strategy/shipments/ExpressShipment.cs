namespace strategy;

public class ExpressShipment : Shipment
{
    public ExpressShipment(int weight) : base(weight){}
    public override double CalculateCost()
    {
        double cost = 1800 * Weight;
        return Prom.CalculatePromotion(cost);
    }
}
