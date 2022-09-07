using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;


namespace VehiculosTransporte.App.Persistencia
{

    public interface IRepositorioDueno
    {
        IEnumerable <Dueno> GetAllDuenos();
        Dueno AddDueño (Dueno dueno);
        Dueno UpdateDueño(Dueno dueno);
        void DeleteDueño (int idDueno);


        IEnumerable<Dueno> GetAllDuenosPorFiltro(string filtro);
    }
}