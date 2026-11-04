public class Comun : TipoPedido
    {
    public Comun(int id, double peso, double costo) : base(id, peso, costo)
    {
        Costo += (peso * 1000);
    }
        public override void GetCosto()
        {
            System.Console.WriteLine($"el costo total de su pedido con id: {Id} es: {Costo}");
        }
    }