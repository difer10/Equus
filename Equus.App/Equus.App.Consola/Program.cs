// See https://aka.ms/new-console-template for more information
using Equus.App.Dominio;
using Equus.App.Persistencia;
namespace Equus.App.Consola
{
    class Program

    {
        private static IrepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio insercion de datos ");
            AddPropietario();
            // BuscarPropietario(14);
        }

        private static void AddPropietario()
        {
            var propietario = new Propietario()
            {
                Cedula = 11,
                Nombre = "Carlos",
                Apellidos = "valderrama",
                Direccion = "AV mompelie",
                Telefono = "10101010",
                CorreoElectronico = "pibe@ffkf",
                NombreHacienda = "La Fortuna"

            };
            _repoPropietario.AddPropietario(propietario);

        }
       

    }
}
