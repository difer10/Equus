using System.ComponentModel.DataAnnotations ;
namespace Equus.App.Dominio;

public class Animal
{
    [Key]
    public int IdAnimal { get; set; }
    public string Nombre { get; set; }
    public string Color { get; set; }
    public string Especie { get; set; }
    public string Raza { get; set; }
    //public HistoriaClinica Historia_Clinica { get; set; }
    //public Veterinario Veterinario {get;set;}
}

