using System.Collections.Generic;  //libreria donde se definen las interfaces
using Equus.App.Dominio;

namespace Equus.App.Persistencia
{
    public interface IrepositorioAnimal
    {
        Animal AddAnimal(Animal animal);
        void DeleteAnimal(int idAnimal);
        IEnumerable<Animal> GetAllAnimals();
        Animal GetAnimal(int idAnimal);
        Animal UpdateAnimal(Animal animal);
    }
}