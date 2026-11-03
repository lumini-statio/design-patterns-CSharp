using decorator;

Cafe cafe = new();

Coffee bebida = new Coffee("Chocolate");
Console.WriteLine($"Bebida base creada: {bebida.Type} - Precio base: ${bebida.Price}");

Console.WriteLine("\nAgregando crema...");
bebida = cafe.AddCream(bebida);

Console.WriteLine("Agregando leche...");
bebida = cafe.AddMilk(bebida);

Console.WriteLine("Agregando primer chocolate...");
bebida = cafe.AddChocolate(bebida);

Console.WriteLine("Agregando segundo chocolate...");
bebida = cafe.AddChocolate(bebida);

Console.WriteLine("Intentando agregar un tercer chocolate...");
bebida = cafe.AddChocolate(bebida);

cafe.MakeOrder(bebida);
Console.WriteLine("\nOrden agregada a la lista de Cafe con MakeOrder.");

double total = bebida.MakeOrder();
Console.WriteLine($"Precio final calculado: ${total}");

Console.WriteLine("\nEntrega del pedido");
Coffee miCafe = cafe.DeliverOrder();
