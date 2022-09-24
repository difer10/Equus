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
    public class ListaPropietariosModel : PageModel
    {
        private readonly IrepositorioPropietario repositorioPropietario;
        public IEnumerable <Propietario> Propietario { set; get; }

        public ListaPropietariosModel()
        {
            this.repositorioPropietario = new RepositorioPropietario(new Equus.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            Propietario = repositorioPropietario.GetAllPropietarios();
        }
    }
}
