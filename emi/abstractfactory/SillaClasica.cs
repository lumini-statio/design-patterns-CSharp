namespace abstractfactory;

public class SillaClasica : Mueble
{
    public SillaClasica() : base("roble", "clasica")
    {
    }

    public override void GetForma()
    {
        System.Console.WriteLine($"Silla {Linea} de {Material}");
    }
}

