namespace abstractfactory;

public abstract class Mueble
{
    private string _material;
    public string Material
    {
        get { return _material; }
        set { _material = value; }
    }
    private string _linea;
    public string Linea
    {
        get { return _linea; }
        set { _linea = value; }
    }

    public Mueble(string material, string linea)
    {
        _material = material;
        _linea = linea;
    }

    public abstract void GetForma();
}
