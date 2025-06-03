const int NUMERO_TAREAS = 10;

List<Tarea> tareas = new List<Tarea>();
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
    tareas.Add(new Tarea(
        i,
        ts[i],
        Math.Min(Math.Max(10, rngesus.Next()), 100)
    ));
}