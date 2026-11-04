// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using strategy;

Console.WriteLine("Hello, World!");
Expres expres = new(1,2,3000);

expres.GetCosto();

Comun comun = new(2,2,3000);
comun.GetCosto();

TiendaOnline tiendaOnline = new();

PorSucursal porSucursal = new(3,2,3000);

tiendaOnline.AgregarPedido(comun);
tiendaOnline.AgregarPedido(expres);

tiendaOnline.GetPedidos();

tiendaOnline.CambiarPedido(comun,porSucursal);

tiendaOnline.GetPedidos();