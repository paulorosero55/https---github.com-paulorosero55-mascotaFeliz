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
    public class EditMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
       
        [BindProperty]
        public Mascota mascota {get; set;}
        public Dueno dueno {get; set;}
        public EditMascotaModel(){
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
        public IActionResult OnPost(int duenoId){
            if(!ModelState.IsValid){
                return Page();
            }
            if(mascota.Id>0){
                mascota = _repoMascota.UpdateMascota(mascota);
            }else{
                _repoMascota.AddMascota(mascota); 
                _repoMascota.AsignarDueno(mascota.Id,duenoId);
                return RedirectToPage("./ListaMascotas");
            }
            return Page();
        }
        
    }
}
