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
    public class DetalleAnimalModel : PageModel
    {
       
        private readonly IrepositorioAnimal repositorioAnimal;

        public Animal Animal{set;get;}
        public DetalleAnimalModel()
        {
         this.repositorioAnimal=new RepositorioAnimal(new Equus.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idAnimal)
        
        {

            Animal=repositorioAnimal.GetAnimal(idAnimal);
            //Console.WriteLine(Animal.Nombres);
                       
         
            if (Animal==null)
            {
                return RedirectToPage("./NoFound");
            }
            else{
               return Page(); 
            }
        }
    }
}

