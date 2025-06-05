public class Operacion
{
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }

    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    public TipoOperacion Tipo { get; set; } // El tipo de operación realizada 
    public double Resultado
    {
        get
        {
            switch (Tipo)
            {
                case TipoOperacion.Suma:
                    return resultadoAnterior + nuevoValor;
                case TipoOperacion.Resta:
                    return resultadoAnterior - nuevoValor;
                case TipoOperacion.Multiplicacion:
                    return resultadoAnterior * nuevoValor;
                case TipoOperacion.Division:
                    return resultadoAnterior / nuevoValor;
                default:
                    return resultadoAnterior;
            }
        }
    }

    public Operacion(double previo, double nuevoVal, TipoOperacion tipo)
    {
        this.resultadoAnterior = previo;
        this.nuevoValor = nuevoVal;
        this.Tipo = tipo;
    }

    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar  // Representa la acción de borrar el resultado actual o el historial 
    }

    public char TipoToString()
    {
        switch (Tipo)
        {
            case TipoOperacion.Suma:
                return '+';
            case TipoOperacion.Resta:
                return '-';
            case TipoOperacion.Multiplicacion:
                return '*';
            case TipoOperacion.Division:
                return '/';
            case TipoOperacion.Limpiar:
                return 'C';
        }
        return 'E';
    }
}