using System;
using Syste.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace VehiculosTransporte.App.Persistenica
{
    public class RepositorioDueño :IRepositorioDueño
    {
        ///<sumary>
        ///Referencia contexto de Dueño
        ///<sumary>

        private readonly AppContext _appContext;
        ///<sumary>
        ///Metodo Constructor
        ///Inyeccion de dependencis para indicar el contexto
        ///<sumary>
        ///<param name "appContext" ></param>//

        public RepositorioDueño (AppContext appContext)
        {
            _appContext = appContext;
        }

        public Dueño AddDueño (Dueño dueño)
        {
            var dueñoAdicionado = _appContext.Dueños.Add(dueño);
            _appContext.SaveChanges();
            return dueñoAdicionado.Entity;
        }
        
        public void DeleteDueño (int idDueño)
        {
            var dueñoEncontrado = _appContext.Dueños.FirstOrDefault(d=>d.Id==idDueño);
            if (dueñoEncontrado ==null)
                return;
            _appContext.Dueños.Remove(dueñoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Dueño> GetAllDueños()
        {
            return GetAllDueños_();
        }

        public IEnumerable<Dueño> GetAllDueñosPorFiltro(string filtro)
        {
            var dueños = GetAllDueños(); 
            if(!String.IsNullOrEmpty(filtro))
            {
                dueños= dueños.Where(s=> s.Nombres.Contains(filtro));
            }
        }

        public Dueño UpdateDueño (Dueño dueño)
        {
            var dueñoEncontrado =_appContext.Dueños.FirstOrDefault(d=>d.Id == dueño.Id);
            if(dueñoEncontrado != null)
            {
                dueñoEncontrado.Nombres = dueño.Nombres;
                dueñoEncontrado.Telefono = dueño.Telefono;
                dueñoEncontrado.Email= dueño.Email;


                _appContext.SaveChanges();
            }
            return dueñoEncontrado;
        }

    }
}