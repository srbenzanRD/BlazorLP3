namespace Models;

public class Producto
{
    public int productoID { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Descripcion { get; set; }
    public double Precio { get; set; }
}
