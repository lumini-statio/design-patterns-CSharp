public abstract class TipoPedido{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    
    private double _peso;
    public double Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }
    private double _costo;
    public double Costo
    {
        get { return _costo; }
        set { _costo = value; }
    }

    public TipoPedido(int id, double peso, double costo)
    {
        this.Id = id;
        this.Peso = peso;
        this.Costo = costo;
    }
    public abstract void GetCosto();
}