namespace strategy;

public class OneProductHasFreeShipment : Promotion
{
    public double CalculatePromotion(double cost)
    {
        return (double)cost / 3;
    }
}
