namespace abstractfactory;

public class SillaModerna : Mueble
{
    public SillaModerna() : base("acero", "moderna")
    {
    }

    public override void GetForma()
    {
        System.Console.WriteLine($"Silla {Linea} de {Material}");
    }
}

