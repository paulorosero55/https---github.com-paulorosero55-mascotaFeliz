using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota Mascota);
        Mascota UpdateMascota(Mascota Mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetMascotaPorFiltro(string filtro);
        IEnumerable<Mascota> GetMascotasPorDueno(int idDueno);
        Dueno AsignarDueno(int idMascota, int idDueno);
        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);
    }
}