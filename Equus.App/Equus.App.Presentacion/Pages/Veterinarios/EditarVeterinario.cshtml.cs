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
    public class EditarVeterinarioModel : PageModel
    {
        private readonly IrepositorioVeterinario repositorioVeterinario;
        public EditarVeterinarioModel()
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new Equus.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Veterinario Veterinario { set; get; }



        public IActionResult OnGet(int idVeterinario)
        {

            Veterinario = repositorioVeterinario.GetVeterinario(idVeterinario);
            if (Veterinario == null)
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
            repositorioVeterinario.UpdateVeterinario(Veterinario);
            return RedirectToPage("./ListaVeterinarios");
        }

    }
}
