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
    public class ListaMascotasDuenoModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
       

        public IEnumerable<Mascota> mascotas {get; set;}
        
       
     /*   public IActionResult OnGet(int? idDueno)
        {
            if(idDueno.HasValue){
                mascotas = _repoMascota.GetMascotasPorDueno(idDueno.Value);
            }
            else{
                mascotas = new IEnumerable<Mascota>();
            }
            if(mascotas == null){
                return RedirectToPage("./NotFound");
            }else{
                return Page();
            }
        }*/
        public ListaMascotasDuenoModel(int idDueno)
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            
        }
        public void OnGet(int? idDueno)
        {
           
                mascotas = _repoMascota.GetMascotasPorDueno(idDueno.Value);
                        
        }
    }
}
