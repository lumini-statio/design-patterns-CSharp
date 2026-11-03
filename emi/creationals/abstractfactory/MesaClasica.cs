namespace abstractfactory;

public class MesaClasica : Mueble
{
    public MesaClasica() : base("roble", "clasica")
    {
    }

    public override void GetForma()
    {
        System.Console.WriteLine($"Mesa {Linea} de {Material}");
    }
}

