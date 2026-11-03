namespace decorator;

public class Coffee
{
    private double _price;
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
    private string _type;
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }
    private int _chocolates;
    public int Chocolates
    {
        get { return _chocolates; }
        set { _chocolates = value; }
    }
    private bool _milk;
    public bool Milk
    {
        get { return _milk; }
        set { _milk = value; }
    }
    private bool _cream;
    public bool Cream
    {
        get { return _cream; }
        set { _cream = value; }
    }
    public Coffee(string type)
    {
        _price = 1500.00;
        _type = type;
        _chocolates = 0;
        _milk = false;
        _cream = false;
    }
    public virtual double MakeOrder()
    {
        return _price;
    }
}
