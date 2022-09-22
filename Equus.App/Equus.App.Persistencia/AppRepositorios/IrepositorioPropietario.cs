using System.Collections.Generic;  //libreria donde se definen las interfaces
using Equus.App.Dominio;

namespace Equus.App.Persistencia
{
    public interface IrepositorioPropietario
    {
        Propietario AddPropietario(Propietario propietario);
        void DeletePropietario(int idPropietario);
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario GetPropietario(int idPropietario);
        Propietario UpdatePropietario(Propietario propietario);
    }
}