namespace abstractfactory;

public class MesaModerna : Mueble
{
    public MesaModerna() : base("vidrio", "moderna")
    {
    }

    public override void GetForma()
    {
        System.Console.WriteLine($"Mesa {Linea} de {Material}");
    }
}

