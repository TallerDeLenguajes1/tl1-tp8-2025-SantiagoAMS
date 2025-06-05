public class Operacion
{
    private double resultadoAnterior ; // Almacena el resultado previo al cálculo actual 
    public double ResultadoAnterior{ get => resultadoAnterior; set => resultadoAnterior = value; }

    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
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
    // Propiedad pública para acceder al nuevo valor utilizado en la operación 
    public double NuevoValor;

    public Operacion(double val, TipoOperacion tipo)
    {
        this.resultadoAnterior = val;
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
}