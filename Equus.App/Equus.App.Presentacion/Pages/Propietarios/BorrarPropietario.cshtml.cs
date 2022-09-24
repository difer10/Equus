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
    public class BorrarPropietarioModel : PageModel
    {
        private readonly IrepositorioPropietario repositorioPropietario;
        public BorrarPropietarioModel()
        {
            this.repositorioPropietario = new RepositorioPropietario(new Equus.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Propietario Propietario { set; get; }



        public IActionResult OnGet(int idPropietario)
        {

            Propietario = repositorioPropietario.GetPropietario(idPropietario);
            if (Propietario == null)
            {
                return RedirectToPage("./NoFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            repositorioPropietario.DeletePropietario(Propietario.IdPersona);
            return RedirectToPage("./ListaPropietarios");
        }

    }
}

