namespace FabricaPJ
{

    using CaracteristicasPJ;
    using DatosPJ;
    public class Personaje
    {
        private Datos datos = new Datos();
        private Caracteristicas caracteristicas = new Caracteristicas();
        DateTime now = DateTime.Today;
        private int edad = 0;

        public Datos Datos { get => datos; set => datos = value; }
        public Caracteristicas Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public DateTime Now { get => now; set => now = value; }
        public int Edad { get => edad; set => edad = value; }
    
        public int calcularEdad(DateTime fechaNac)
    {
        Edad = Now.Year - fechaNac.Year;

        if(fechaNac.Month > Now.Month)
        {
            Edad = Edad-1;
        }

        return Edad;
    }
    
    }
}
namespace CreacionPJ
{
    using FabricaPJ;
    using DatosPJ;
    public class FabricaPersonajes
    {


        public Personaje cargarPersonajes()
        {
            Personaje NPersonaje = new Personaje();
            Random rand = new Random();

            NPersonaje.Caracteristicas.Agilidad = rand.Next(1, 20);
            NPersonaje.Caracteristicas.Mana = rand.Next(1, 20);
            NPersonaje.Caracteristicas.Fuerza = rand.Next(1, 20);
            NPersonaje.Caracteristicas.Nivel = rand.Next(1, 400);
            NPersonaje.Caracteristicas.Armadura = rand.Next(1, 20);

            int dato = rand.Next(1, 5);

            switch (dato)
            {
                case 1:
                    NPersonaje.Datos.Tipo = Tipos.Guerrero;
                    NPersonaje.Datos.Nombre = Nombres.Dark_Knight;
                    NPersonaje.Datos.Apodo = Apodos.DK;

                    break;
                case 2:
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Nombre = Nombres.Dark_Wizard;
                    NPersonaje.Datos.Apodo = Apodos.DW;

                    break;
                case 3:
                    NPersonaje.Datos.Tipo = Tipos.Elf;
                    NPersonaje.Datos.Nombre = Nombres.Fairy_Elf;
                    NPersonaje.Datos.Apodo = Apodos.FE;

                    break;
                case 4:
                    NPersonaje.Datos.Tipo = Tipos.GladiadorMago;
                    NPersonaje.Datos.Nombre = Nombres.Magic_Gladiator;
                    NPersonaje.Datos.Apodo = Apodos.MG;

                    break;
                case 5:
                    NPersonaje.Datos.Tipo = Tipos.Commander;
                    NPersonaje.Datos.Nombre = Nombres.Dark_Lord;
                    NPersonaje.Datos.Apodo = Apodos.DL;

                    break;
                default:
                    break;
            }

            NPersonaje.Datos.FechadeNac = new DateTime(rand.Next(1989, 2006), rand.Next(1, 13), rand.Next(1, 31));

            NPersonaje.Datos.Edad = NPersonaje.calcularEdad(NPersonaje.Datos.FechadeNac);

            NPersonaje.Datos.Stamina = 100;

            return NPersonaje;
        }

        public void mostrarDatos(List<Personaje>ListadodePersonajes)
        {
        foreach (var Personaje in ListadodePersonajes)
        {
            
            Console.WriteLine("\n\n----------PERSONAJE----------");
            Console.WriteLine("Tipo: " + Personaje.Datos.Tipo);
            Console.WriteLine("Nombre: " + Personaje.Datos.Nombre);
            Console.WriteLine("Apodo: " + Personaje.Datos.Apodo);
            Console.WriteLine("Fecha de nacimiento: " + Personaje.Datos.FechadeNac.ToShortDateString());
            Console.WriteLine($"Edad: [{Personaje.Datos.Edad}] años");
            Console.WriteLine($"Nivel: [{Personaje.Caracteristicas.Nivel}]");
            Console.WriteLine($"Fuerza: [{Personaje.Caracteristicas.Fuerza}] puntos");
            Console.WriteLine($"Agilidad: [{Personaje.Caracteristicas.Agilidad}] puntos");
            Console.WriteLine($"Salud: [{Personaje.Datos.Stamina}] puntos");
            Console.WriteLine($"Mana: [{Personaje.Caracteristicas.Mana}] puntos");
            Console.WriteLine($"Armadura: [{Personaje.Caracteristicas.Armadura}] puntos");
        }
        }
        public void mejoraDeHabilidades(Personaje ganador)
        {
            if (ganador.Datos.Stamina == 100)
            {
                Random rand = new Random();
                int agregarFuerza = rand.Next(5, 11);
                ganador.Caracteristicas.Fuerza = ganador.Caracteristicas.Fuerza + (ganador.Caracteristicas.Fuerza / agregarFuerza);
            }
            else
            {
                ganador.Datos.Stamina = ganador.Datos.Stamina + (ganador.Datos.Stamina / 10);
                if (ganador.Datos.Stamina > 100)
                {
                    ganador.Datos.Stamina = 100;
                }
            }
        }

    }

}




















