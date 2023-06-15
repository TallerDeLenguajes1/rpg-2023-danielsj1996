using FabricaPJ;
using CreacionPJ;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var ListadoDePersonajes = new List<Personaje>();
var FabPj = new FabricaPersonajes();
var Personaje1 = FabPj.cargarPersonajes();
var Personaje2 = FabPj.cargarPersonajes();
ListadoDePersonajes.Add(Personaje1);
ListadoDePersonajes.Add(Personaje2);


FabPj.mostrarDatos(ListadoDePersonajes);















