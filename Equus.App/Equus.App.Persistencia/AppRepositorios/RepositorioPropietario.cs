using System.Collections.Generic;  //libreria donde se definen las interfaces
using Equus.App.Dominio;
using System.Linq;

namespace Equus.App.Persistencia
{
   public class RepositorioPropietario:IrepositorioPropietario
   {
      private readonly AppContext _appContext;
      public RepositorioPropietario(AppContext appContext)
      {
        _appContext=appContext;
      }
      Propietario IrepositorioPropietario.AddPropietario(Propietario propietario)
      {
         var PropietarioAdicionado=_appContext.Propietarios.Add(propietario);
         _appContext.SaveChanges();
         return PropietarioAdicionado.Entity;
      }


      void  IrepositorioPropietario.DeletePropietario(int idPropietario)
      {
        var PropietarioEncontrado=_appContext.Propietarios.FirstOrDefault(p=>p.IdPersona==idPropietario );
       
        _appContext.Propietarios.Remove(PropietarioEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Propietario> IrepositorioPropietario.GetAllPropietarios()
      {
         return _appContext.Propietarios;  
      }

      Propietario IrepositorioPropietario.GetPropietario(int idPropietario)
      {
       return _appContext.Propietarios.FirstOrDefault(p=>p.IdPersona==idPropietario);

      }

      Propietario IrepositorioPropietario.UpdatePropietario(Propietario propietario)
      {
       var PropietarioEncontrado= _appContext.Propietarios.FirstOrDefault(p=>p.IdPersona==propietario.IdPersona);  
        if(PropietarioEncontrado!=null)
        {
         PropietarioEncontrado.Cedula=propietario.Cedula;
         PropietarioEncontrado.Nombre=propietario.Nombre;
         PropietarioEncontrado.Apellidos=propietario.Apellidos;
         PropietarioEncontrado.Telefono=propietario.Telefono;
         PropietarioEncontrado.CorreoElectronico=propietario.CorreoElectronico;
         PropietarioEncontrado.NombreHacienda=propietario.NombreHacienda;
          _appContext.SaveChanges();

        }

        return PropietarioEncontrado;
      }
   }
}