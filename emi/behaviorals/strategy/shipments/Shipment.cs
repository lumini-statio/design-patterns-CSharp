namespace strategy;

public abstract class Shipment
{
    private Config config;
    private double _weight;
    public double Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }
    private static Promotion _prom;
    public static Promotion Prom
    {
        get { return _prom; }
        set { _prom = value; }
    }
    public Shipment(double weight)
    {
        config = Config.GetInstance();
        _prom = config.GlobalPromotion;
        _weight = weight;
    }
    public abstract double CalculateCost();
}
