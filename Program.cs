namespace Ejercico_compuertas_2do_intento;

class Program
{
    static void Main()
    {
        int botonGarageA = 0;
        int botonGarageB = 0;
        int botonGarageC = 1;
        GarageGate garage1 = new GarageGate(botonGarageA, botonGarageB, botonGarageC);
        Console.WriteLine(garage1.CalcularSalida()); // resultado = 1

        garage1.botonA = 1;
        garage1.botonB = 1;
        Console.WriteLine(garage1.CalcularSalida()); // resultado = 1




    }
}