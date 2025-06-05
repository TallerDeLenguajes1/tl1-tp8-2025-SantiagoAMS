namespace EspacioCalculadora;

public class Calculadora
{

    public readonly List<Operacion> Historial = new List<Operacion>();
    private double dato = 0;
    public void Sumar(double termino)
    {
        Historial.Add(new Operacion(dato, Operacion.TipoOperacion.Suma));
        dato += termino;
    }

    public void Restar(double termino)
    {
        Historial.Add(new Operacion(dato, Operacion.TipoOperacion.Resta));
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        Historial.Add(new Operacion(dato, Operacion.TipoOperacion.Multiplicacion));
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        Historial.Add(new Operacion(dato, Operacion.TipoOperacion.Division));
        dato /= termino;
    }

    public void Limpiar()
    {
        Historial.Add(new Operacion(dato, Operacion.TipoOperacion.Limpiar));
        dato = 0;
    }

    public double Resultado
    {
        get
        {
            if (Historial.Count() == 0)
            {
                return 0;
            }
            return Historial.LastOrDefault().Resultado;
        }
    }

    public void Revertir()
    {
        if (Historial.Count() == 0)
        {
            return;
        }
        Historial.RemoveAt(Historial.Count()-1);
    }

}