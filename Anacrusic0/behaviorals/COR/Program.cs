// See https://aka.ms/new-console-template for more information
using COR;

Console.WriteLine("Hello, World!");
Supervisor supervisor = new();
Gerente gerente = new();
JefeDeArea jefeDeArea = new();
Director director = new();

supervisor.AsignarSuperior(gerente);
gerente.AsignarSuperior(jefeDeArea);
jefeDeArea.AsignarSuperior(director);

supervisor.ProcesarGasto(500000000);