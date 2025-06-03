public static class Utilidades
{
    public static int LeerEntero(string texto = "Ingresá un número entero")
    {
        int ret = 0;
        while (true)
        {
            Console.WriteLine(texto);
            Console.Write("> ");
            string s = Console.ReadLine();
            if (int.TryParse(s is null ? "" : s, out ret))
            {
                return ret;
            }
            PrintError("Error, no ingresaste un entero...");
        }
    }

    public static double LeerDouble(string texto = "Ingresá un número")
    {
        double ret = 0;
        while (true)
        {
            Console.WriteLine(texto);
            Console.Write("> ");
            string s = Console.ReadLine();
            if (double.TryParse(s is null ? "" : s, out ret))
            {
                return ret;
            }
            PrintError("Error, no ingresaste un número...");
        }
    }

    public static void Pausa()
    {
        ConsoleColor old = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Pulsa una tecla para continuar...");
        Console.ReadKey();
        Console.ForegroundColor = old;
    }
    public static void PrintError(string text = "Opcion invalida...")
    {
        ConsoleColor old = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ForegroundColor = old;
    }

    public static string LeerString(string texto = "Ingresa una cadena")
    {
        Console.Write($"\n{texto}\n> ");
        string ret = Console.ReadLine();
        return ret ?? "";
    }

}

