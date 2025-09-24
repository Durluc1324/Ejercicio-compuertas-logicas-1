namespace Ejercico_compuertas_2do_intento;

public class GarageGate
{
    private And and1 = new And("Compuerta AND 1 (A,B) ");
    private And and2 = new And("Compuerta AND 2 (B) ");
    private And and3 = new And("Compuerta AND 3(or 1, C) ");
    private Not not1 = new Not("Compuerta NOT 1 (A)");
    private Not not2 = new Not("Compuerta NOT 2 (B)");
    private Or or1 = new Or("Compuerta OR (AND 1, AND 2");

    private int botonA;
    private int botonB;
    private int botonC;

    public GarageGate(int unBotonA, int unBotonB, int unBotonC)
    {
        botonA = unBotonA;
        botonB = unBotonB;
        botonC = unBotonC;
    }

    public int CalcularSalida()
    {
        //Limpia la lista de entradas para que no se acumulen las entradas anteriores si re reutiliza el objeto
        and1.LimpiarEntradas();
        and2.LimpiarEntradas();
        and3.LimpiarEntradas();
        not1.LimpiarEntradas();
        not2.LimpiarEntradas();
        or1.LimpiarEntradas();
        
        //Flujo de creación 
        and1.AgregarEntrada(botonA);
        and1.AgregarEntrada(botonB);
        not1.AgregarEntrada(botonA);
        not2.AgregarEntrada(botonB);
        
        and2.AgregarEntrada(not1.Calcular());
        and2.AgregarEntrada(not2.Calcular());
        
        or1.AgregarEntrada(and1.Calcular());
        or1.AgregarEntrada(and2.Calcular());
        
        and3.AgregarEntrada(or1.Calcular());
        and3.AgregarEntrada(botonC);

        return and3.Calcular();

    }

}