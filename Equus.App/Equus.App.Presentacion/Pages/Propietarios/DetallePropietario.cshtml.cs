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
       public class DetallePropietarioModel : PageModel
    {

        private readonly IrepositorioPropietario RepositorioPropietario;

        public Propietario propietario {get;set;}

        public DetallePropietarioModel ()
        {
            this.RepositorioPropietario=new RepositorioPropietario(new Equus.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idPropietario)
        {
            propietario=RepositorioPropietario.GetPropietario(idPropietario);
            if(propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }
    }
}
