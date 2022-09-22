using System.ComponentModel.DataAnnotations;
namespace Equus.App.Dominio;

public class HistoriaClinica
{
    [Key]
    public int IdHistoria { get; set; }
    public string Temperatura { get; set; }
    public float Peso { get; set; }
    public float FrecuenciaRespiratoria { get; set; }
    public float FrecuenciaCardiaca { get; set; }
    public string EstadoAnimo { get; set; }
    public DateTime FechaVisita  { get; set; }
    // Genero de la persona
    public string Recomendacion { set; get; }
    public Veterinario VeterinarioDesignado { set; get; }

}

