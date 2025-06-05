namespace EspacioCalculadora;

public class Calculadora
{

    private readonly List<Operacion> Historial = [];

    public void Sumar(double termino)
    {
        Historial.Add(new Operacion(Resultado, termino, Operacion.TipoOperacion.Suma));
    }

    public void Restar(double termino)
    {
        Historial.Add(new Operacion(Resultado, termino, Operacion.TipoOperacion.Resta));
    }

    public void Multiplicar(double termino)
    {
        Historial.Add(new Operacion(Resultado, termino, Operacion.TipoOperacion.Multiplicacion));
    }

    public void Dividir(double termino)
    {
        Historial.Add(new Operacion(Resultado, termino, Operacion.TipoOperacion.Division));
    }

    public void Limpiar() //Deja el valor en 0 SIN LIMPIAR EL HISTORIAL
    {
        Historial.Add(new Operacion(Resultado, 0, Operacion.TipoOperacion.Limpiar));
    }


    public void LimpiarHistorial() //Esta funcion adicional permite limpiar el historial (junto al resultado)
    {
        Historial.Clear();
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
                Console.WriteLine($"{i + 1}: {o.Resultado}");
                continue;
            }
            Console.WriteLine($"{i + 1}: {o.ResultadoAnterior} {o.TipoToString()} {o.NuevoValor} = {o.Resultado}");
        }
    }


}