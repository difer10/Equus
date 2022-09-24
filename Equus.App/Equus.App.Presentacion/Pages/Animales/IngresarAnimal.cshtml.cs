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
    public class IngresarAnimalModel : PageModel
    {
       private readonly IrepositorioAnimal repositorioAnimal;

        public IngresarAnimalModel()
        {
         this.repositorioAnimal=new RepositorioAnimal(new Equus.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Animal Animal{set;get;}

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
          repositorioAnimal.AddAnimal(Animal);  
          return RedirectToPage("./ListaAnimal");
        }
    }
}
