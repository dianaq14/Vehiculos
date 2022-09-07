using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;


namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioMecanico
    {
        IEnumerable <Mecanico> GetAllMecanicos();
        Dueño AddMecanico (Mecanico mecanico);
        Dueño UpdateMecanico(Mecanico mecanico);
        void DeleteMecanico(int idMecanico);


        IEnumerable<Mecanico> GetAllMecanicosPorFiltro(string filtro);
    }
}