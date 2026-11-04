namespace strategy;

public class LocalPickupShipment : Shipment
{
    public LocalPickupShipment(int weight) : base(weight){}
    public override double CalculateCost()
    {
        return Prom.CalculatePromotion(0);
    }
}
