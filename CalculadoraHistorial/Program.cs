using EspacioCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Simular();
    }
    static void Simular()
    {
        Calculadora c = new Calculadora();

        c.Sumar(30);
        Console.WriteLine(c.Resultado);
        c.Restar(10);
        Console.WriteLine(c.Resultado);
        c.Multiplicar(5);
        Console.WriteLine(c.Resultado);

        c.ImprimirHistorial();
        c.Limpiar();
        c.Sumar(15);
        c.LimpiarHistorial();
        c.Sumar(2);
        c.ImprimirHistorial();
        
    }
}