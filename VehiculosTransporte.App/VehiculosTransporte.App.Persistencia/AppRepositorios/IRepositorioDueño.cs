using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;


namespace VehiculosTransporte.App.Persistencia
{

    public interface RepositoriosDueño
    {
        IEnumerable <Dueño> GetAllDueños();
        Dueño AddDueño (Dueño dueño);
        Dueño UpdateDueño{Dueño dueño};
        void DeleteDueño {int idDueño};


        IEnumerable<Dueño> GetAllDueñosPorFiltro(string filtro);
    }
}