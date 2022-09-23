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
    public class ListaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
       

        public IEnumerable<Mascota> mascotas {get; set;}
        [BindProperty(SupportsGet = true)]
        public Dueno Dueno {get; set;}
        public Veterinario Veterinario {get; set;}
        
        public ListaMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            
        }
        public void OnGet(Mascota mascota)
        {
            mascota.Dueno = Dueno;
            mascota.Veterinario = Veterinario;
            mascotas = _repoMascota.GetAllMascotas();
            
        }
    }
}
