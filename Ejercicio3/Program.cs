int cargamax = 2500; //Modificar para escoger cuanto tarda en cargar
for (double carga = 0; carga <= cargamax; carga++)
{
    Console.WriteLine($"Carga al {(int)(carga / cargamax * 100)}%");
    Console.Write("|");
    for (int i = 1; i <= (100 / 5); i++)
    {
        if ((int)(carga / cargamax * 100) >= i * (100 / 20))
        {
            Console.Write("■");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("|\n\n");
}