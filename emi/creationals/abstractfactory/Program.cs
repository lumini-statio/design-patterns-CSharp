using abstractfactory;

var statement = """
Una mueblería online vende combos de living formados por una silla y una mesa. Hay dos
líneas: Moderna (silla de acero, mesa de vidrio) y Clásica (silla y mesa de roble). Hubo
reclamos porque se entregaron combos mezclados, con una silla moderna y una mesa
clásica.

El año próximo se suma una línea Nórdica. El código que arma y muestra los combos tiene
que hacer imposible mezclar líneas, y agregar una línea no debe obligar a modificarlo.
Para verificar: mostrar un combo de cada línea con el mismo código.
Silla moderna de acero - Mesa moderna de vidrio
Silla clásica de roble - Mesa clásica de roble
""";

LineaFactory lineaClasica = new LineaClasicaFactory();
Mueble sillaClasica = lineaClasica.CrearSilla();
Mueble mesaClasica = lineaClasica.CrearMesa();

sillaClasica.GetForma();
mesaClasica.GetForma();

System.Console.WriteLine();

LineaFactory lineaModerna = new LineaModernaFactory();
Mueble sillaModerna = lineaModerna.CrearSilla();
Mueble mesaModerna = lineaModerna.CrearMesa();

sillaModerna.GetForma();
mesaModerna.GetForma();
