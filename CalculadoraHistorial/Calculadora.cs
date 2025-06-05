namespace EspacioCalculadora;

public class Calculadora
{

    public readonly List<Operacion> Historial = new List<Operacion>();
    private double dato = 0;
    public void Sumar(double termino)
    {
        Historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Suma));
        dato += termino;
    }

    public void Restar(double termino)
    {
        Historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Resta));
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        Historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Multiplicacion));
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        Historial.Add(new Operacion(dato, termino, Operacion.TipoOperacion.Division));
        dato /= termino;
    }

    public void Limpiar()
    {
        Historial.Add(new Operacion(dato, 0, Operacion.TipoOperacion.Limpiar));
        dato = 0;
    }

    public double Resultado
    {
        get
        {
            if (Historial.Count == 0)
            {
                return 0;
            }
            return Historial.LastOrDefault().Resultado;
        }
    }

    public void Deshacer()
    {
        var count = Historial.Count;
        if (count == 0)
        {
            return;
        }
        Historial.RemoveAt(count - 1);
    }

    public void ImprimirHistorial()
    {
        for (int i = 0; i < Historial.Count; i++)
        {
            var o = Historial[i];
            if (o.Tipo == Operacion.TipoOperacion.Limpiar)
            {
                Console.WriteLine($"{i}: {o.Resultado}");
                continue;
            }
            Console.WriteLine($"{i}: {o.ResultadoAnterior} {o.TipoToString()} {o.NuevoValor} = {o.Resultado}");
        }
    }
}