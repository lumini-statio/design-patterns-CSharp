namespace strategy;

public class Config
{
    private static Config instance;
    private Promotion _globalPromotion;
    public Promotion GlobalPromotion
    {
        get { return _globalPromotion; }
        set { _globalPromotion = value; }
    }
    private Config()
    {
        _globalPromotion = (Promotion)new ExceedHightPriceDiscount();
    }
    public static Config GetInstance()
    {
        if (instance == null)
        {
            return new Config();
        }
        return instance;
    }
}
