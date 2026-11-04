namespace strategy;

public class ExceedHightPriceDiscount : Promotion
{
    public double CalculatePromotion(double cost)
    {
        return (double)cost * 0.9;
    }
}
