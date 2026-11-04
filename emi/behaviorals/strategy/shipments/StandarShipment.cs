namespace strategy;

public class StandarShipment : Shipment
{
    public StandarShipment(int weight) : base(weight){}
    public override double CalculateCost()
    {
        double cost = 1000 * Weight;
        return Prom.CalculatePromotion(cost);
    }
}
