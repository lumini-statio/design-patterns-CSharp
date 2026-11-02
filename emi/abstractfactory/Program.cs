using abstractfactory;

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
