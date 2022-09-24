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
    public class IngresarVeterinarioModel : PageModel
    {
       private readonly IrepositorioVeterinario repositorioVeterinario;

        public IngresarVeterinarioModel()
        {
         this.repositorioVeterinario=new RepositorioVeterinario(new Equus.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Veterinario Veterinario{set;get;}

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
          repositorioVeterinario.AddVeterinario(Veterinario);  
          return RedirectToPage("./ListaVeterinarios");
        }
    }
}
