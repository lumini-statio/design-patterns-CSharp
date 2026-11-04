using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy
{
    public class TiendaOnline
    {
        public List<TipoPedido> pedidos = new List<TipoPedido>();
        public void AgregarPedido(TipoPedido pedido)
        {
            pedidos.Add(pedido);
        }

        public TipoPedido CambiarPedido(TipoPedido pedido, TipoPedido nuevoPedido)
        {
            System.Console.WriteLine("cambiando pedidos...");
            for (int i = 0; i < pedidos.Count; i++)
            {
                if (pedidos[i].Id == pedido.Id)
                {
                    pedidos[i] = nuevoPedido;
                    return nuevoPedido;
                }
            }
            System.Console.WriteLine("pedidos cambiados con exito!");
            return nuevoPedido;
        }
        public void GetPedidos()
        {
            System.Console.WriteLine("estos son los pedidos de su carrito:");
            foreach (TipoPedido pedido in pedidos)
            {
                System.Console.WriteLine($"pedido con id: {pedido.Id}");
            }
        }
    }
}