using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class Expres : TipoPedido
    {
        public Expres(int id, double peso, double costo) : base(id, peso, costo)
        {
            Costo += (peso * 1800);
        }
        public override void GetCosto()
        {
            System.Console.WriteLine($"el costo total de su pedido con id: {Id} es: {Costo}");
        }
    }
}