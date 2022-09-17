using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class DetallesDuenoModel : PageModel
    {
        private readonly IRepositorioDueno _repoDuenos;
        public Dueno dueno {get; set; }
        public DetallesDuenoModel(){
            this._repoDuenos = new RepositorioDueno(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int duenoId)
        {
            dueno = _repoDuenos.GetDueno(duenoId);
            if(dueno==null){
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
