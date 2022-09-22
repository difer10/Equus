using System.Collections.Generic;  //libreria donde se definen las interfaces
using Equus.App.Dominio;
using System.Linq;

namespace Equus.App.Persistencia
{
   public class RepositorioAnimal:IrepositorioAnimal
   {
      private readonly AppContext _appContext;
      public RepositorioAnimal(AppContext appContext)
      {
        _appContext=appContext;
      }
      Animal IrepositorioAnimal.AddAnimal(Animal animal)
      {
         var AnimalAdicionado=_appContext.Animales.Add(animal);
         _appContext.SaveChanges();
         return AnimalAdicionado.Entity;
      }


      void  IrepositorioAnimal.DeleteAnimal(int idAnimal)
      {
        var AnimalEncontrado=_appContext.Animales.FirstOrDefault(p=>p.IdAnimal==idAnimal );
       
        _appContext.Animales.Remove(AnimalEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Animal> IrepositorioAnimal.GetAllAnimals()
      {
         return _appContext.Animales;  
      }

      Animal IrepositorioAnimal.GetAnimal(int idAnimal)
      {
       return _appContext.Animales.FirstOrDefault(p=>p.IdAnimal==idAnimal);

      }

      Animal IrepositorioAnimal.UpdateAnimal(Animal animal)
      {
       var AnimalEncontrado= _appContext.Animales.FirstOrDefault(p=>p.IdAnimal==animal.IdAnimal);  
        if(AnimalEncontrado!=null)
        {
         //AnimalEncontrado.IdAnimal=Animal.IdAnimal;
         AnimalEncontrado.Nombre=animal.Nombre;
         AnimalEncontrado.Color=animal.Color;
         AnimalEncontrado.Especie=animal.Especie;
         AnimalEncontrado.Raza=animal.Raza;
         
          _appContext.SaveChanges();

        }

        return AnimalEncontrado;
      }
   }
}