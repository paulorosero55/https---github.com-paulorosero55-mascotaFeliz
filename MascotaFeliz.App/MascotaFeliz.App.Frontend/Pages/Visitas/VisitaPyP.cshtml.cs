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
        public static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        public static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        public static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        [BindProperty]
        public VisitaPyP visita {get; set;}
        public Veterinario veterinario {get; set;}
        public Mascota mascota {get; set;}
        public Historia historia {get; set;}
        public IEnumerable<Veterinario> listaVeterinarios {get; set;}

        public VisitaPyPModel(){
            this._repoVisita = new RepositorioVisita(new Persistencia.AppContext());
        }
        

        public void OnGet(int historiaId)
        {
            historia = _repoHistoria.GetHistoria(historiaId);
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }
        public IActionResult OnPost(int historiaId, int IdVeterinario){
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            
            Console.WriteLine("Prrint 1");
            Console.WriteLine("id de visita "+visita.Id);
           historia = _repoHistoria.GetHistoria(historiaId);
            Console.WriteLine("id de historia OnPost "+historia.Id);
       /*     if(!ModelState.IsValid){
                 Console.WriteLine("Prrint 5");
                return Page();
            }*/
            if(visita.Id>0){
                Console.WriteLine("Prrint 2");
                visita = _repoVisita.UpdateVisita(visita);
                
            }else{
                Console.WriteLine("Prrint 3");
             //   return RedirectToPage("../Historias/HistoriaClinica");
                visita.IdVeterinario =IdVeterinario;
                
                _repoVisita.AddVisita(visita);
                _repoHistoria.AsignarVisitaPyP(historia.Id, visita.Id);
                Console.WriteLine("Id visita adicionada "+visita.Id);
                
              //  return RedirectToPage("../Historias/HistoriaClinica");
                
            }
            Console.WriteLine("Prrint 4");
            return Page();
        }
    }
}
