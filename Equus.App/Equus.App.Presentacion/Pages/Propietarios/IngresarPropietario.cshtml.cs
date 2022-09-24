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
    public class IngresarPropietarioModel : PageModel
    {
       private readonly IrepositorioPropietario repositorioPropietario;

        public IngresarPropietarioModel()
        {
         this.repositorioPropietario=new RepositorioPropietario(new Equus.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Propietario Propietario{set;get;}

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
          repositorioPropietario.AddPropietario(Propietario);  
          return RedirectToPage("./ListaPropietarios");
        }
    }
}
