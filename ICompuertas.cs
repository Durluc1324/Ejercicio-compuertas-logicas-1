namespace Ejercico_compuertas_2do_intento;

public interface ICompuertas
{
    public string Nombre { get; set; }
    public List<int> Entradas { get; set; } 
    public int Salida { get; set; }

    public void AgregarEntrada(int entrada)
    {
        
    }

    public int Calcular()
    {
        return Salida;
    }

}