using FabricaPJ;
using CreacionPJ;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var ListadoDePersonajes = new List<Personaje>();
var FabPj = new FabricaPersonajes();
var Personaje1 = FabPj.cargarPersonajes();
var Personaje2 = FabPj.cargarPersonajes();
ListadoDePersonajes.Add(Personaje1);
ListadoDePersonajes.Add(Personaje2);
int indefinido;
string PathCarpeta, PathJson;

FabPj.mostrarDatos(ListadoDePersonajes);

creacionDeCarpetasYVariables(out indefinido, out ListadoDePersonajes, out PathCarpeta, out PathJson);

pelea(Personaje1, Personaje2);


void creacionDeCarpetasYVariables(out int indefinido, out List<Personaje> ListadoDePersonajes, out string PathCarpeta, out string PathJson)
{
    indefinido = 999;


    ListadoDePersonajes = new List<Personaje>();

    // Acá creo los archivos csv y Json
    PathCarpeta = "ganadores.csv";
    PathJson = "jugadores.json";
    if (!File.Exists(PathCarpeta))
    {
        File.Create(PathCarpeta);
    }

    if (!File.Exists(PathJson))
    {
        File.Create(PathJson);
    }
}




void pelea(Personaje Personaje1, Personaje Personaje2)
{

    Combate combate = new Combate();
    Random rand = new Random();

    int primeroEnAtacar = rand.Next(1, 3);
    if (primeroEnAtacar == 1)
    {
        Console.WriteLine($"\nComienza atacando el jugador 1 con {Personaje1.Datos.Nombre}");
    }
    else
    {
        Console.WriteLine($"\nComienza atacando el jugador 2 con {Personaje2.Datos.Nombre}");
    }

    if ((Personaje1.Datos.Salud > 0) && (Personaje2.Datos.Salud > 0)) //corroboro que tengan salud sino no tiene sentido seguir la batalla
    {
        if (primeroEnAtacar == 1)
        {
            Personaje2.Datos.Salud = combate.combate(Personaje1, Personaje2); //ataca primero jugador 1, defiende jugador 2
            Personaje1.Datos.Salud = combate.combate(Personaje2, Personaje1); //ataca jugador 2, defiende jugador 1
        }
        else
        {
            Personaje1.Datos.Salud = combate.combate(Personaje2, Personaje1); //ataca primero jugador 2, defiende jugador 1
            Personaje2.Datos.Salud = combate.combate(Personaje1, Personaje2); //ataca jugador 1, defiende jugador 2
        }
    }
    int resultado = corroborarPerdedor(Personaje1, Personaje2);
    if (resultado == 1)
    {
        mostrarGanador(Personaje2);
    }
    else
    {
        mostrarGanador(Personaje1);
    }
}


int corroborarPerdedor(Personaje personaje1, Personaje personaje2)
{
    int resultado;
    if (Personaje1.Datos.Salud != 0 && Personaje2.Datos.Salud != 0)
    {
        if (Personaje1.Datos.Salud > Personaje2.Datos.Salud)
        {
            FabPj.mejoraDeHabilidades(Personaje1);
            Console.WriteLine("Gana el Personaje :" + Personaje1.Datos.Nombre);
            resultado = 1;
            return resultado;
        }
        else
        {
            FabPj.mejoraDeHabilidades(personaje2);
            Console.WriteLine("Gana el Personaje :" + Personaje1.Datos.Nombre);
            resultado = 2;
            return resultado;
        }
    }
    else
    {
        if (personaje1.Datos.Salud == 0 && Personaje2.Datos.Salud == 0)
        {
            Console.WriteLine("Hay empate entre ambos Personajes");
            return 5;
        }
        else
        {
            if (Personaje1.Datos.Salud == 0)
            {
                FabPj.mejoraDeHabilidades(Personaje2);
                Console.WriteLine("Gana el Personaje :" + Personaje1.Datos.Nombre);
                return 2;
            }
            else
            {
                FabPj.mejoraDeHabilidades(Personaje1);
                return 1;
            }
        }
    }
}

void mostrarGanador(Personaje Ganador)
{
    Console.WriteLine("\n----------EL GANADOR ES----------");
    Console.WriteLine($"\n         {Ganador.Datos.Nombre}");
    Console.WriteLine($"\nCon un total de {Ganador.Datos.Salud} vidas\n\n");
    string linea = $"\nGANADOR: {Ganador.Datos.Nombre} con [{Ganador.Datos.Salud}] vidas restantes\n\n";
    File.AppendAllText(PathCarpeta, linea);

}












