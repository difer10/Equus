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
    public class DetalleVeterinarioModel : PageModel
    {
       
        private readonly IrepositorioVeterinario repositorioVeterinario;

        public Veterinario veterinario{set;get;}
        public DetalleVeterinarioModel()
        {
         this.repositorioVeterinario=new RepositorioVeterinario(new Equus.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idVeterinario)
        
        {

            veterinario=repositorioVeterinario.GetVeterinario(idVeterinario);
            //Console.WriteLine(Veterinario.Nombres);
                       
         
            if (veterinario==null)
            {
                return RedirectToPage("./NoFound");
            }
            else{
               return Page(); 
            }
        }
    }
}
