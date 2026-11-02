namespace abstractfactory;

public class LineaModernaFactory : LineaFactory
{
    public Mueble CrearMesa()
    {
        return new MesaModerna();
    }

    public Mueble CrearSilla()
    {
        return new SillaModerna();
    }
}
