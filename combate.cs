using FabricaPJ;
public class Combate{

    private int ataque;  // Poder de disparo
    private int efectividad;  // Efectividad de disparo
    private float valorDeAtaque;  // Valor de ataque
    private int defensa;  // Poder de defensa
    private int consdeAjuste;  // Máximo daño provocable
    private float dañoProvocado;  // Daño provocado

    public int Ataque { get => ataque; set => ataque = value; }
    public int Efectividad { get => efectividad; set => efectividad = value; }
    public float ValorDeAtaque { get => valorDeAtaque; set => valorDeAtaque = value; }
    public int Defensa { get => defensa; set => defensa = value; }
    public int ConsdeAjuste { get => consdeAjuste; set => consdeAjuste = value; }
    public float DañoProvocado { get => dañoProvocado; set => dañoProvocado = value; }



    public int combate(Personaje atacante, Personaje defensor){
        
        Ataque = atacante.Caracteristicas.DañoMagico * atacante.Caracteristicas.Fuerza * atacante.Caracteristicas.Nivel;

        Random rand = new Random();
        Efectividad = rand.Next(1,100);

        ValorDeAtaque = Ataque * Efectividad;

        Defensa = defensor.Caracteristicas.Armadura * defensor.Caracteristicas.Velocidad;

        ConsdeAjuste = 5000;
        
        DañoProvocado = ((ValorDeAtaque  - Defensa) / ConsdeAjuste);

        defensor.Datos.Salud = defensor.Datos.Salud - Convert.ToInt32(DañoProvocado);

        return defensor.Datos.Salud;
    }
}