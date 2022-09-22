using System.Collections.Generic;  //libreria donde se definen las interfaces
using Equus.App.Dominio;
using System.Linq;

namespace Equus.App.Persistencia
{
   public class RepositorioVeterinario:IrepositorioVeterinario
   {
      private readonly AppContext _appContext;
      public RepositorioVeterinario(AppContext appContext)
      {
        _appContext=appContext;
      }
      Veterinario IrepositorioVeterinario.AddVeterinario(Veterinario veterinario)
      {
         var VeterinarioAdicionado=_appContext.Veterinarios.Add(veterinario);
         _appContext.SaveChanges();
         return VeterinarioAdicionado.Entity;
      }


      void  IrepositorioVeterinario.DeleteVeterinario(int idVeterinario)
      {
        var VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p=>p.IdPersona==idVeterinario );
       
        _appContext.Veterinarios.Remove(VeterinarioEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Veterinario> IrepositorioVeterinario.GetAllVeterinarios()
      {
         return _appContext.Veterinarios;  
      }

      Veterinario IrepositorioVeterinario.GetVeterinario(int idVeterinario)
      {
       return _appContext.Veterinarios.FirstOrDefault(p=>p.IdPersona==idVeterinario);

      }

      Veterinario IrepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
      {
       var VeterinarioEncontrado= _appContext.Veterinarios.FirstOrDefault(p=>p.IdPersona==veterinario.IdPersona);  
        if(VeterinarioEncontrado!=null)
        {
         VeterinarioEncontrado.Cedula=veterinario.Cedula;
         VeterinarioEncontrado.Nombre=veterinario.Nombre;
         VeterinarioEncontrado.Apellidos=veterinario.Apellidos;
         VeterinarioEncontrado.Telefono=veterinario.Telefono;
         VeterinarioEncontrado.CorreoElectronico=veterinario.CorreoElectronico;
         VeterinarioEncontrado.TarjetaProfesional=veterinario.TarjetaProfesional;
          _appContext.SaveChanges();

        }

        return VeterinarioEncontrado;
      }
   }
}