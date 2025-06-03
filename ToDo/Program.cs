using Microsoft.VisualBasic;

internal class Program
{
    private static List<Tarea> pendientes = new List<Tarea>();
    private static List<Tarea> realizadas = new List<Tarea>();
    private static ConsoleColor colorOriginal = Console.ForegroundColor;
    private static void Main(string[] args)
    {
        const int NUMERO_TAREAS = 10;
        Random rngesus = new Random();

        string[] ts = [
            "Cocinar la cena",
            "Darse de baja de metodos",
            "Reparar las luces",
            "Reparar las mesas",
            "Realizar el TP",
            "Comprar fruta",
            "Preparar los finales",
            "Nombre generico de tarea A",
            "Nombre interesante de tarea B",
            "Nombre particular de tarea C",
        ];
        for (int i = 0; i < NUMERO_TAREAS; i++)
        {

            pendientes.Add(new Tarea(
                i,
                ts[i],
                Math.Min(Math.Max(10, rngesus.Next() % 100), 100)
            ));
        }

        int opc = 0;
        while (opc != 5)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   1  -  Listar tareas");
            Console.WriteLine("   2  -  Transferir tarea a realizadas");
            Console.WriteLine("   3  -  Buscar tarea por ID");
            Console.WriteLine("   4  -  Buscar tarea por descripcion");
            Console.WriteLine("   5  -  Salir del programa");
            Console.WriteLine("========================================");

            opc = Utilidades.LeerEntero("Ingresa una opcion");

            switch (opc)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Listar("----- Listando Realizadas -----", realizadas);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Listar("----- Listando Pendientes -----", pendientes);
                    Console.ForegroundColor = colorOriginal;
                    break;
                case 2:
                    Transferir();
                    break;
                case 3:
                    BuscarPorID(pendientes);
                    break;
                case 4:
                    BuscarPorDescripcion(pendientes);
                    break;
                case 5:
                    continue;
                default:
                    Utilidades.PrintError("Opción inesperada");
                    break;
            }
            Utilidades.Pausa();
        }
    }

    static void Listar(Tarea t)
    {
        if (t == null)
        {
            Utilidades.PrintError("Se ha ingresado una tarea nula...");
            return;
        }
        Console.WriteLine($"Tarea: \n  - TareaID: {t.TareaID}\n  - Duracion: {t.Duracion}\n  - Descr: {t.Descripcion}");
    }
    static void Listar(string titulo, List<Tarea> lista)
    {
        Console.WriteLine(titulo);
        Console.WriteLine(" ID\t | Duración | Descripción");
        foreach (Tarea t in lista)
        {
            Console.WriteLine($" {t.TareaID}\t | {t.Duracion}       | {t.Descripcion}");
        }
    }

    static void Transferir()
    {
        if (pendientes.Count() == 0)
        {
            Utilidades.PrintError("La lista de pendientes esta vacía...");
            return;
        }
        string desc = Utilidades.LeerString("Ingresa la descripcion de la tarea a transferir");
        Tarea t = pendientes.FirstOrDefault(t => t.Descripcion.Equals(desc));
        if (t == null)
        {
            Utilidades.PrintError($"No se ha encontrado la tarea con descripcion \"{desc}\"...\nBuscando una similar");
            t = pendientes.FirstOrDefault(t => t.Descripcion.ToLower().Contains(desc.ToLower()));
            if (t == null)
            {
                Utilidades.PrintError($"No hay coincidencias...");
                return;
            }
        }
        ListarQueSeEncontro(t);
        if (Utilidades.LeerBooleano("¿Mover a la lista de finalizadas?"))
        {
            pendientes.Remove(t);
            realizadas.Add(t);
            Utilidades.PrintSuccess("Tarea transferida exitosamente");
        }
    }

    static void BuscarPorDescripcion(List<Tarea> tareas)
    {
        if (pendientes.Count() == 0)
        {
            Utilidades.PrintError("La lista de pendientes esta vacía...");
            return;
        }

        string desc = Utilidades.LeerString("Ingresa la descripcion de la tarea a buscar");
        Tarea t = pendientes.FirstOrDefault(t => t.Descripcion.Equals(desc));
        if (t == null)
        {
            Utilidades.PrintError($"No se ha encontrado la tarea con descripcion \"{desc}\"...\nBuscando una similar");
            t = pendientes.FirstOrDefault(t => t.Descripcion.ToLower().Contains(desc.ToLower()));
            if (t == null)
            {
                Utilidades.PrintError($"No hay coincidencias...");
                return;
            }
        }
        ListarQueSeEncontro(t);
    }

    static void BuscarPorID(List<Tarea> tareas)
    {
        if (pendientes.Count() == 0)
        {
            Utilidades.PrintError("La lista de pendientes esta vacía...");
            return;
        }
        
        int id = Utilidades.LeerEntero("Ingresa la ID de la tarea a buscar");
        Tarea t = pendientes.FirstOrDefault(t => t.TareaID == id);
        if (t == null)
        {
            Utilidades.PrintError($"No hay coincidencias...");
            return;
        }
        ListarQueSeEncontro(t);
    }

    private static void ListarQueSeEncontro(Tarea t)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tarea encontrada");
        Listar(t);
        Console.ForegroundColor = colorOriginal;
        
    }
}