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

            if (fechaNac.Month > Now.Month)
            {
                Edad = Edad - 1;
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

         

            int dato = rand.Next(1, 32);

            switch (dato)
            {
                case 1:
                    NPersonaje.Datos.Nombre = Nombres.Aatrox;
                    NPersonaje.Datos.Tipo = Tipos.Luchador;
                    NPersonaje.Datos.Region = Region.Noxus;

                    break;
                case 2:
                    NPersonaje.Datos.Nombre = Nombres.Ahri;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Jonia;

                    break;
                case 3:
                    NPersonaje.Datos.Nombre = Nombres.Amumu;
                    NPersonaje.Datos.Tipo = Tipos.Tank;
                    NPersonaje.Datos.Region = Region.Shurima;

                    break;
                case 4:
                    NPersonaje.Datos.Nombre = Nombres.Ashe;
                    NPersonaje.Datos.Tipo = Tipos.ADCarry;
                    NPersonaje.Datos.Region = Region.Freljord;

                    break;
                case 5:
                    NPersonaje.Datos.Nombre = Nombres.Blitzcrank;
                    NPersonaje.Datos.Tipo = Tipos.Utilidad;
                    NPersonaje.Datos.Region = Region.Zaun;

                    break;
                case 6:
                    NPersonaje.Datos.Nombre = Nombres.Brand;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Runaterra;

                    break;
                case 7:
                    NPersonaje.Datos.Nombre = Nombres.Braum;
                    NPersonaje.Datos.Tipo = Tipos.Tank;
                    NPersonaje.Datos.Region = Region.Freljord;

                    break;
                case 8:
                    NPersonaje.Datos.Nombre = Nombres.Caitlyn;
                    NPersonaje.Datos.Tipo = Tipos.ADCarry;
                    NPersonaje.Datos.Region = Region.Piltover;

                    break;
                case 9:
                    NPersonaje.Datos.Nombre = Nombres.Cho_Gath;
                    NPersonaje.Datos.Tipo = Tipos.Tank;
                    NPersonaje.Datos.Region = Region.El_Vacio;


                    break;
                case 10:
                    NPersonaje.Datos.Nombre = Nombres.Darius;
                    NPersonaje.Datos.Tipo = Tipos.Luchador;
                    NPersonaje.Datos.Region = Region.Noxus;

                    break;
                case 11:
                    NPersonaje.Datos.Nombre = Nombres.GangPlank;
                    NPersonaje.Datos.Tipo = Tipos.Luchador;
                    NPersonaje.Datos.Region = Region.Aguasturbias;

                    break;
                case 12:
                    NPersonaje.Datos.Nombre = Nombres.Garen;
                    NPersonaje.Datos.Tipo = Tipos.Luchador;
                    NPersonaje.Datos.Region = Region.Demacia;

                    break;
                case 13:
                    NPersonaje.Datos.Nombre = Nombres.Jhin;
                    NPersonaje.Datos.Tipo = Tipos.ADCarry;
                    NPersonaje.Datos.Region = Region.Jonia;

                    break;
                case 14:
                    NPersonaje.Datos.Nombre = Nombres.Jinx;
                    NPersonaje.Datos.Tipo = Tipos.ADCarry;
                    NPersonaje.Datos.Region = Region.Zaun;


                    break;
                case 15:
                    NPersonaje.Datos.Nombre = Nombres.Kayn;
                    NPersonaje.Datos.Tipo = Tipos.Asesino;
                    NPersonaje.Datos.Region = Region.Jonia;

                    break;
                case 16:

                    NPersonaje.Datos.Nombre = Nombres.Leona;
                    NPersonaje.Datos.Tipo = Tipos.Tank;
                    NPersonaje.Datos.Region = Region.Targon;
                    break;
                case 17:
                    NPersonaje.Datos.Nombre = Nombres.Lux;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Demacia;

                    break;
                case 18:
                    NPersonaje.Datos.Nombre = Nombres.Malzahar;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.El_Vacio;

                    break;
                case 19:
                    NPersonaje.Datos.Nombre = Nombres.Maokai;
                    NPersonaje.Datos.Tipo = Tipos.Tank;
                    NPersonaje.Datos.Region = Region.Isla_de_la_Sombra;

                    break;
                case 20:
                    NPersonaje.Datos.Nombre = Nombres.Mordekaiser;
                    NPersonaje.Datos.Tipo = Tipos.Luchador;
                    NPersonaje.Datos.Region = Region.Isla_de_la_Sombra;

                    break;
                case 21:
                    NPersonaje.Datos.Nombre = Nombres.Morgana;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Demacia;

                    break;
                case 22:
                    NPersonaje.Datos.Nombre = Nombres.Pyke;
                    NPersonaje.Datos.Tipo = Tipos.Asesino;
                    NPersonaje.Datos.Region = Region.Aguasturbias;

                    break;
                case 23:
                    NPersonaje.Datos.Nombre = Nombres.Shaco;
                    NPersonaje.Datos.Tipo = Tipos.Asesino;
                    NPersonaje.Datos.Region = Region.Runaterra;

                    break;
                case 24:

                    NPersonaje.Datos.Nombre = Nombres.Singed;
                    NPersonaje.Datos.Tipo = Tipos.Tank;
                    NPersonaje.Datos.Region = Region.Zaun;
                    break;
                case 25:

                    NPersonaje.Datos.Nombre = Nombres.Teemo;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Ciudad_de_Bandle;
                    break;
                case 26:

                    NPersonaje.Datos.Nombre = Nombres.Thresh;
                    NPersonaje.Datos.Tipo = Tipos.Utilidad;
                    NPersonaje.Datos.Region = Region.Isla_de_la_Sombra;
                    break;
                case 27:

                    NPersonaje.Datos.Nombre = Nombres.Tristana;
                    NPersonaje.Datos.Tipo = Tipos.ADCarry;
                    NPersonaje.Datos.Region = Region.Ciudad_de_Bandle;
                    break;
                case 28:
                    NPersonaje.Datos.Nombre = Nombres.Velkoz;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.El_Vacio;

                    break;
                case 29:
                    NPersonaje.Datos.Nombre = Nombres.Vi;
                    NPersonaje.Datos.Tipo = Tipos.Luchador;
                    NPersonaje.Datos.Region = Region.Zaun;

                    break;
                case 30:
                    NPersonaje.Datos.Nombre = Nombres.Xerath;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Shurima;

                    break;
                case 31:
                    NPersonaje.Datos.Nombre = Nombres.Ziggs;
                    NPersonaje.Datos.Tipo = Tipos.Mago;
                    NPersonaje.Datos.Region = Region.Zaun;

                    break;
                case 32:
                    NPersonaje.Datos.Nombre = Nombres.Zilean;
                    NPersonaje.Datos.Tipo = Tipos.Utilidad;
                    NPersonaje.Datos.Region = Region.Runaterra;
                    break;
                default:
                    break;
            }

            NPersonaje.Datos.FechadeNac = new DateTime(rand.Next(1989, 2006), rand.Next(1, 13), rand.Next(1, 31));

            NPersonaje.Datos.Edad = NPersonaje.calcularEdad(NPersonaje.Datos.FechadeNac);

            NPersonaje.Datos.Salud = 100;
               if (NPersonaje.Datos.Tipo == Tipos.ADCarry)
            {
                NPersonaje.Caracteristicas.Nivel = rand.Next(1, 10);
                NPersonaje.Caracteristicas.Fuerza = 15;
                NPersonaje.Caracteristicas.Velocidad = 10;
                NPersonaje.Caracteristicas.DañoMagico = 10;
                NPersonaje.Caracteristicas.Armadura = 5;

            }
            else
            {
                if (NPersonaje.Datos.Tipo == Tipos.Asesino)
                {
                    NPersonaje.Caracteristicas.Nivel = rand.Next(1, 10);
                    NPersonaje.Caracteristicas.Fuerza = 15;
                    NPersonaje.Caracteristicas.Velocidad = 15;
                    NPersonaje.Caracteristicas.DañoMagico = 5;
                    NPersonaje.Caracteristicas.Armadura = 10;

                }
                else
                {
                    if (NPersonaje.Datos.Tipo == Tipos.Luchador)
                    {
                        NPersonaje.Caracteristicas.Nivel = rand.Next(1, 10);
                        NPersonaje.Caracteristicas.Fuerza = 20;
                        NPersonaje.Caracteristicas.Velocidad = 10;
                        NPersonaje.Caracteristicas.DañoMagico = 5;
                        NPersonaje.Caracteristicas.Armadura = 10;
                    }
                    else
                    {
                        if (NPersonaje.Datos.Tipo == Tipos.Mago)
                        {
                            NPersonaje.Caracteristicas.Velocidad = 10;
                            NPersonaje.Caracteristicas.Fuerza = 10;
                            NPersonaje.Caracteristicas.DañoMagico = 20;
                            NPersonaje.Caracteristicas.Nivel = rand.Next(1, 10);
                            NPersonaje.Caracteristicas.Armadura = 10;

                        }
                        else
                        {
                            if (NPersonaje.Datos.Tipo == Tipos.Tank)
                            {
                                NPersonaje.Caracteristicas.Nivel = rand.Next(1, 10);
                                NPersonaje.Caracteristicas.Fuerza = 15;
                                NPersonaje.Caracteristicas.Velocidad = 10;
                                NPersonaje.Caracteristicas.DañoMagico = 20;
                                NPersonaje.Caracteristicas.Armadura = 20;

                            }
                            else
                            {
                                if (NPersonaje.Datos.Tipo == Tipos.Utilidad)
                                {
                                    NPersonaje.Caracteristicas.Nivel = rand.Next(1, 10);
                                    NPersonaje.Caracteristicas.Fuerza = 10;
                                    NPersonaje.Caracteristicas.Velocidad = 12;
                                    NPersonaje.Caracteristicas.DañoMagico = 20;
                                    NPersonaje.Caracteristicas.Armadura = 12;


                                }
                            }

                        }

                    }


                }

            }

            return NPersonaje;
        }

        public void mostrarDatos(List<Personaje> ListadodePersonajes)
        {
            foreach (var Personaje in ListadodePersonajes)
            {

                Console.WriteLine("\n\n----------PERSONAJE----------");
                Console.WriteLine("Tipo: " + Personaje.Datos.Tipo);
                Console.WriteLine("Nombre: " + Personaje.Datos.Nombre);
                Console.WriteLine("Region: " + Personaje.Datos.Region);
                Console.WriteLine("Fecha de nacimiento: " + Personaje.Datos.FechadeNac.ToShortDateString());
                Console.WriteLine($"Edad: [{Personaje.Datos.Edad}] años");
                Console.WriteLine($"Nivel: [{Personaje.Caracteristicas.Nivel}]");
                Console.WriteLine($"Fuerza: [{Personaje.Caracteristicas.Fuerza}] puntos");
                Console.WriteLine($"Velocidad: [{Personaje.Caracteristicas.Velocidad}] puntos");
                Console.WriteLine($"Salud: [{Personaje.Datos.Salud}] puntos");
                Console.WriteLine($"dañoMagico: [{Personaje.Caracteristicas.DañoMagico}] puntos");
                Console.WriteLine($"Armadura: [{Personaje.Caracteristicas.Armadura}] puntos");
            }
        }
        public void mejoraDeHabilidades(Personaje ganador)
        {
            if (ganador.Datos.Salud == 100)
            {
                Random rand = new Random();
                int agregarFuerza = rand.Next(5, 11);
                ganador.Caracteristicas.Fuerza = ganador.Caracteristicas.Fuerza + (ganador.Caracteristicas.Fuerza / agregarFuerza);
            }
            else
            {
                ganador.Datos.Salud = ganador.Datos.Salud + (ganador.Datos.Salud / 10);
                if (ganador.Datos.Salud > 100)
                {
                    ganador.Datos.Salud = 100;
                }
            }
        }

    }

}




















