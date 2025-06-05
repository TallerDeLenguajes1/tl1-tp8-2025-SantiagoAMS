namespace EspacioCalculadora;

public class Calculadora
{

    private double dato =0;
    public void Sumar(double termino)
    {
        dato += termino;
    }

    public void Restar(double termino)
    {
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        dato /= termino;
    }

    public void Limpiar()
    {
        dato = 0;
    }

    public double Resultado
    {
        get => dato;
    }

}