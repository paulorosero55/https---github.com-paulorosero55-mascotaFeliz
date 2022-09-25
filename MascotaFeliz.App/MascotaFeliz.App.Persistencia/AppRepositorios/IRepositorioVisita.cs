using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisita
    {
        VisitaPyP AddVisita(VisitaPyP visita);
        IEnumerable<VisitaPyP> GetAllVisitas();
        IEnumerable<VisitaPyP> GetVisitasPorHistoria(int idHistoria);
        VisitaPyP UpdateVisita(VisitaPyP visita);
        VisitaPyP GetVisita(int idVisita);

    }
}