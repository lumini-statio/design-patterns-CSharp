// Una máquina expendedora prepara té y café. 
// Las dos bebidas siguen la misma secuencia:
// hervir agua, preparar la infusión, servir en la taza y agregar extras. 

// Hervir y servir son
// idénticos para todas; preparar y agregar extras cambian (té: saquito y limón; café: filtrado,
// azúcar y leche).

// El fabricante va a sumar bebidas, como el mate cocido. Ninguna bebida nueva debe poder
// alterar el orden de la secuencia ni repetir el código de los pasos comunes

using System.Reflection.Metadata;
using templateMethod;

System.Console.WriteLine();
PrepareTea tea = new();
tea.TemplateInfusion();
tea.AddExtra(ComplementType.LEMON);

System.Console.WriteLine();
PrepareCoffee coffee = new();
coffee.TemplateInfusion();
coffee.AddExtra(ComplementType.SUGAR);
coffee.AddExtra(ComplementType.MILK);

System.Console.WriteLine();