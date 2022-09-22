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
        public static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        [BindProperty]

        public Mascota mascota {get; set;}
        public Dueno dueno {get; set;}
        public Veterinario veterinario {get; set;}
        public IEnumerable<Veterinario> listaVeterinarios {get; set;}

        
        public EditMascotaModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? mascotaId)
        {
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
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
        public IActionResult OnPost(int duenoId, int veterinarioId){
            if(!ModelState.IsValid){
                return Page();
            }
            if(mascota.Id>0){
                _repoMascota.AsignarVeterinario(mascota.Id,veterinarioId);

                mascota = _repoMascota.UpdateMascota(mascota);
                // RedirectToPage("./ListaMascotas");
            }else{
                _repoMascota.AddMascota(mascota); 
                _repoMascota.AsignarDueno(mascota.Id,duenoId);
                _repoMascota.AsignarVeterinario(mascota.Id,veterinarioId);
                return RedirectToPage("./ListaMascotas");
            }
            return Page();
        }
        
    }
}
