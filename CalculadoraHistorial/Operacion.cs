public class Operacion
{
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
    private TipoOperacion operacion { get; set; } // El tipo de operación realizada 
    public double Resultado
    {
        get
        {
            switch (operacion)
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
    

    // Constructor u otros métodos necesarios para inicializar y gestionar la operación 
    // ... 

    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar  // Representa la acción de borrar el resultado actual o el historial 
    }
}