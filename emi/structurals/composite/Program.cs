// Una aplicación de escritorio tiene un menú con opciones simples y submenús. Un submenú
// puede contener opciones y otros submenús, sin límite de profundidad.

// Hay que mostrar el menú completo, con una sangría de dos espacios por nivel. El código
// que muestra el menú no debe preguntar si cada elemento es una opción o un submenú:
// alcanza con pedirle a la raíz que se muestre.

// Para verificar: armar este menú y mostrarlo desde la raíz.
// Archivo
//  Nuevo
//  Abrir
//  Recientes
//  informe.txt
//  notas.txt
//  Salir

using composite;

Option informe = new("informe.txt");
Option notas = new("notas.txt");
Option salir = new("salir.exe");

List<Option> options = new()
{
    informe,
    notas,
    salir
};

Menu recientes = new("Recientes");

foreach (var item in options)
{
    recientes.AddComponent(item);
}

Menu abrir = new("Abrir");
Menu nuevo = new("Nuevo");
Menu archivo = new("Archivo");

abrir.AddComponent(recientes);
nuevo.AddComponent(abrir);
archivo.AddComponent(nuevo);

archivo.GetDescription();