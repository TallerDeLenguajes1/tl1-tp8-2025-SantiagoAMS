const int NUMERO_TAREAS = 10;

List<Tarea> pendientes = new List<Tarea>();
List<Tarea> realizadas = new List<Tarea>();
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
        Math.Min(Math.Max(10, rngesus.Next()), 100)
    ));
}

int opc = 0;
while (opc != 4)
{
    Console.WriteLine("========================================");
    Console.WriteLine("   1  -  Listar tareas");
    Console.WriteLine("   2  -  Transferir tarea a realizadas");
    Console.WriteLine("   3  -  Buscar tarea por descripcion");
    Console.WriteLine("   4  -  Salir del programa");
    Console.WriteLine("========================================");

    opc = Utilidades.LeerEntero("Ingresa una opcion");

    switch (opc)
    {
        case 1:
            Listar();
            break;
        case 2:
            Transferir();
            break;
        case 3:
            BuscarPorDescripcion();
            break;
        case 4:
            continue;
        default:
            break;

    }
}

static void Listar(string titulo, List<Tarea> lista)
{
    Console.WriteLine(titulo);
    Console.WriteLine(" ID\t | Duración | Descripción");
    foreach (Tarea t in lista)
    {
        Console.WriteLine($"{t.TareaID}\t");
    }
}

static void Transferir()
{

}

static void BuscarPorDescripcion()
{

}
