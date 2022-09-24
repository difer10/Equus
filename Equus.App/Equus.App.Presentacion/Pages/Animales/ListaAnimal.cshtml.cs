using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Equus.App.Dominio;
using Equus.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
//librerias opcionales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equus.App.Presentacion.Pages
{
    public class ListaAnimalModel : PageModel
    {
        private readonly IrepositorioAnimal repositorioAnimal;
        public IEnumerable <Animal> Animal { set; get; }

        public ListaAnimalModel()
        {
            this.repositorioAnimal = new RepositorioAnimal(new Equus.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            Animal = repositorioAnimal.GetAllAnimals();
        }
    }
}
