public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }

    private int duracion;
    public int Duracion
    {
        get
        {
            return duracion;
        }
        set
        {
            if (value >= 10 && value <= 100)
            {
                duracion = value;
            }
            throw new Exception("El valor debe estar entre [10,100]...");
        }
    }

     // Validar que esté entre 10 y 100 
    // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario 

    public Tarea(int id, string descripcion, int duracion)
    {
        this.Descripcion = descripcion;
        this.TareaID = id;
        this.Duracion = duracion;
    }
}