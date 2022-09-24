// See https://aka.ms/new-console-template for more information
using Equus.App.Dominio;
using Equus.App.Persistencia;
namespace Equus.App.Consola
{
    class Program

    {
        private static IrepositorioPropietario _repoPropietario = new RepositorioPropietario
        (new Persistencia.AppContext());
        private static IrepositorioAnimal _repoAnimal = new RepositorioAnimal
        (new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio insercion de datos ");
            AddPropietario();
            AddAnimal();
            // BuscarPropietario(14);
        }

        private static void AddPropietario()
        {
            var propietario = new Propietario()
            {
                Cedula = 145451,
                Nombre = "Jaime",
                Apellidos = "Garzon",
                Direccion = "AV mompelie",
                Telefono = "10101010",
                CorreoElectronico = "pibe@ffkf",
                NombreHacienda = "La Fortuna"

            };
            var propietario2 = new Propietario()
            {
                Cedula = 108390,
                Nombre = "Fernando",
                Apellidos = "Carballo",
                Direccion = "AV mompelie",
                Telefono = "10101010",
                CorreoElectronico = "pibe@ffkf",
                NombreHacienda = "La Fortuna"

            };
           
            _repoPropietario.AddPropietario(propietario);
            _repoPropietario.AddPropietario(propietario2);

        }
        private static void AddAnimal()
        {

         var animal = new Animal()
            {
                Nombre = "Pecas",
                Color = "negro",
                Especie = "Caballo",
                Raza = "Trochador",
            };
            var animal2 = new Animal()
            {
                Nombre = "Pecas2",
                Color = "cafe",
                Especie = "Caballo",
                Raza = "Trochador",
            };
            _repoAnimal.AddAnimal(animal);
            _repoAnimal.AddAnimal(animal2);
        }

    }
}
