namespace Ejercico_compuertas_2do_intento;

public class Not: ICompuertas
{
    public string Nombre { get; set; }
    public List<int> Entradas { get; set; } 
    public int Salida { get; set; }

    public Not(string unNombre)
    {
        Nombre = unNombre;
        Entradas = new List<int>();
    }

    public void AgregarEntrada(int entrada)
    {
        Entradas.Add(entrada);
    }

    public int Calcular()
    {
        if (Entradas[0] == 1)
            Salida = 0;
        else if (Entradas[0] == 0)
            Salida = 1;
        
        return Salida;
    }
}