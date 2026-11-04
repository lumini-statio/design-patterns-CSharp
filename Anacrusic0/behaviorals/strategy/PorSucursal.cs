using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class PorSucursal : TipoPedido
    {
        public PorSucursal(int id, double peso, double costo) : base(id, peso, costo)
        {
        }
        public override void GetCosto()
        {
            System.Console.WriteLine($"el costo total de su pedido con id: {Id} es: {Costo}");
        }
    }
}