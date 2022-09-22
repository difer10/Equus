using System.Collections.Generic;  //libreria donde se definen las interfaces
using Equus.App.Dominio;

namespace Equus.App.Persistencia
{
    public interface IrepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario GetVeterinario(int idVeterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
    }
}