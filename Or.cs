namespace Ejercico_compuertas_2do_intento;

public class Or: ICompuertas
{
    public string Nombre { get; set; }
    public List<int> Entradas { get; set; } 
    public int Salida { get; set; }

    public Or(string unNombre)
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
        Salida = Entradas.Max();
        return Salida;
    }
}