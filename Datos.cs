namespace DatosPJ
{
    public enum Tipos
    {
        Mago,
        Elf,
        Guerrero,
        GladiadorMago,
        Commander


    }

    public enum Nombres
    {
        Dark_Wizard,
        Dark_Knight,
        Magic_Gladiator,
        Fairy_Elf,
        Dark_Lord
    }

    public enum Apodos
    {
        DK,
        MG,
        DW,
        FE,
        DL

    }
    public class Datos
    {
        private Tipos tipo;
        private Nombres nombre;
        private Apodos apodo;
        private DateTime fechadeNac;
        private int edad;
        private int stamina;

        public Tipos Tipo { get => tipo; set => tipo = value; }
        public Nombres Nombre { get => nombre; set => nombre = value; }
        public Apodos Apodo { get => apodo; set => apodo = value; }
        public DateTime FechadeNac { get => fechadeNac; set => fechadeNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Stamina { get => stamina; set => stamina = value; }
    }

}













