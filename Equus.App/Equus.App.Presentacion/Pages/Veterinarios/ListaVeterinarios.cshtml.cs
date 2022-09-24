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
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IrepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> Veterinario { set; get; }

        public ListaVeterinariosModel()
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new Equus.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            Veterinario = repositorioVeterinario.GetAllVeterinarios();
        }
    }
}
