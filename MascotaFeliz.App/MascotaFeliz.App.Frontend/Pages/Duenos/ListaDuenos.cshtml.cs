using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;

        public IEnumerable<Dueno> duenos {get; set;}

        public ListaDuenosModel()
        {
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }
        public void OnGet()
        {
            duenos = _repoDueno.GetAllDuenos();
        }
    }
}
