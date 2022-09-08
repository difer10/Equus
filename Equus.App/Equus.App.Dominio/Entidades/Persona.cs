namespace Equus.App.Dominio;

public class Persona
{
    // Identificador único de cada persona
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }
}
