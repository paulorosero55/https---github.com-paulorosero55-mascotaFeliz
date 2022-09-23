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
    public class VisitaPyPModel : PageModel
    {
        private readonly IRepositorioVisita _repoVisita;
        [BindProperty]
        public VisitaPyP visita {get; set;}

        public VisitaPyPModel(){
            this._repoVisita = new RepositorioVisita(new Persistencia.AppContext());
        }
        

        public void OnGet()
        {
        }
        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(visita.Id>0){
                visita = _repoVisita.UpdateVisita(visita);
            }else{
                _repoVisita.AddVisita(visita);
            }
            return Page();
        }
    }
}
