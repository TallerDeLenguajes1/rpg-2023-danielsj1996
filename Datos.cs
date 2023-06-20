namespace DatosPJ
{
    public enum Tipos
    {
        Mago,
        Luchador,
        Asesino,
        Utilidad,
        Tank,
        ADCarry


    }

    public enum Nombres
    {
        Caitlyn,
        Jinx,
        Brand,
        Leona,
        Ashe,
        Ahri,
        Teemo,
        Tristana,
        Pyke,
        GangPlank,
        Garen,
        Lux,
        Morgana,
        Braum,
        Kayn,
        Jhin,
        Mordekaiser,
        Darius,
        Vi,
        Xerath,
        Amumu,
        Thresh,
        Maokai,
        Shaco,
        Zilean,
        Cho_Gath,
        Velkoz,
        Malzahar,
        Ziggs,
        Singed,
        Blitzcrank,
        Aatrox



    }

    public enum Region
    {
        Jonia,
        Noxus,
        Shurima,
        Runaterra,
        Piltover,
        Zaun,
        El_Vacio,
        Ciudad_de_Bandle,
        Demacia,
        Freljord,
        Aguasturbias,
        Isla_de_la_Sombra,
        Targon



    }
    public class Datos
    {
        private Tipos tipo;
        private Nombres nombre;
        private Region region;
        private DateTime fechadeNac;
        private int edad;
        private int salud;

        public Tipos Tipo { get => tipo; set => tipo = value; }
        public Nombres Nombre { get => nombre; set => nombre = value; }
        public Region Region { get => region; set => region = value; }
        public DateTime FechadeNac { get => fechadeNac; set => fechadeNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
    }

}













