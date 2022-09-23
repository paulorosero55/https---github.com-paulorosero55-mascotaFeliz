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
    public class HistoriaClinicaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
     //   private readonly IRepositorioHistoria _repoHistoria;

        public Mascota mascota {get; set; }

         public HistoriaClinicaModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            
        }
       
        public IActionResult OnGet(int? mascotaId)
        {
            if(mascotaId.HasValue){
                mascota = _repoMascota.GetMascota(mascotaId.Value);
            }
            else{
                mascota = new Mascota();
            }
            if(mascota == null){
                return RedirectToPage("./NotFound");
            }else{
                return Page();
            }
        }
    }
}
