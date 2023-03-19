class JugadorCarga
{
    //Atributos
    string tipo, nombre;
    int vidamax, vida, poder, velocidad;
    //Constructor
    public JugadorCarga()
    {
        this.tipo = "Guerrero";
        this.nombre = "Jugador";
        this.vida = 1;
        this.velocidad = 1;
        this.poder = 1;
    }
    public JugadorCarga(string Tipo, string Nombre, int Vida, int Velocidad, int Poder)
    {
        this.tipo = Tipo;
        this.nombre = Nombre;
        this.vida = Vida;
        this.velocidad = Velocidad;
        this.poder = Poder;
    }
    //Metodos
    public void Descansar()
    {
        this.vida = this.vidamax;
    }
    public void Atacar()
    {
        Console.WriteLine($"{this.nombre} ha atacado.");
    }
}