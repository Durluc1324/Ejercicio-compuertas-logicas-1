namespace Ejercico_compuertas_2do_intento;

public class And: ICompuertas
{
    public string Nombre { get; set; }
    public List<int> Entradas { get; set; } 
    public int Salida { get; set; }

    public And( string unNombre)
    {
        this.Nombre = unNombre;
        this.Entradas = new List<int>();

    }

    public void AgregarEntrada(int entrada)
    {
        this.Entradas.Add(entrada);
    }

    public int Calcular()
    {
        this.Salida = 1;
        foreach (int variable in Entradas)
        {
            this.Salida *= variable;
        }

        return Salida;
    }

    public void LimpiarEntradas()
    {
        Entradas.Clear();
    }
}