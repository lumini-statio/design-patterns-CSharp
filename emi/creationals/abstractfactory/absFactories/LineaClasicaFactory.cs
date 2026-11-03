namespace abstractfactory;

public class LineaClasicaFactory : LineaFactory
{
    public Mueble CrearMesa()
    {
        return new MesaClasica();
    }

    public Mueble CrearSilla()
    {
        return new SillaClasica();
    }
}
