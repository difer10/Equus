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
    public class EditarAnimalModel : PageModel
    {
        private readonly IrepositorioAnimal repositorioAnimal;
        [BindProperty]
        public Animal animal{set;get;}
        public EditarAnimalModel()
        {
            this.repositorioAnimal=new RepositorioAnimal(new Equus.App.Persistencia.AppContext());
        }

         public IActionResult OnGet(int idAnimal)
        {
           
           animal=repositorioAnimal.GetAnimal(idAnimal);
          if(animal==null){
            return RedirectToPage("./NoFound");
           }
           else{
            return Page();
           }
        }
        public IActionResult OnPost()
        {
           animal=repositorioAnimal.UpdateAnimal(animal);
           //repositorioAnimal.DeleteAnimal(animal.IdPersona);
            return RedirectToPage("./ListaAnimal"); 
        }
      
    }
}
