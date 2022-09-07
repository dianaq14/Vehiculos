using System;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace VehiculosTransporte.App.Persistenica
{
    public class RepositorioDueno :IRepositorioDueno
    {
        ///<sumary>
        ///Referencia contexto de Dueno
        ///<sumary>

        private readonly AppContext _appContext;
        ///<sumary>
        ///Metodo Constructor
        ///Inyeccion de dependencis para indicar el contexto
        ///<sumary>
        ///<param name "appContext" ></param>//

        public RepositorioDueno (AppContext appContext)
        {
            _appContext = appContext;
        }

        public Dueno AddDueno (Dueno dueno)
        {
            var duenoAdicionado = _appContext.Duenos.Add(dueno);
            _appContext.SaveChanges();
            return duenoAdicionado.Entity;
        }
        
        public void DeleteDueno (int idDueno)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(d=>d.Id==idDueno);
            if (duenoEncontrado ==null)
                return;
            _appContext.Duenos.Remove(duenoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Dueno> GetAllDuenos()
        {
            return GetAllDuenos_();
        }

        public IEnumerable<Dueno> GetAllDuenosPorFiltro(string filtro)
        {
            var duenos = GetAllDuenos(); 
            if(!String.IsNullOrEmpty(filtro))
            {
                duenos= duenos.Where(s=> s.Nombres.Contains(filtro));
            }
        }

        public Dueno UpdateDueno (Dueno dueno)
        {
            var duenoEncontrado =_appContext.Duenos.FirstOrDefault(d=>d.Id == dueno.Id);
            if(duenoEncontrado != null)
            {
                duenoEncontrado.Nombres = dueno.Nombres;
                duenoEncontrado.Telefono = dueno.Telefono;
                duenoEncontrado.Email= dueno.Email;


                _appContext.SaveChanges();
            }
            return duenoEncontrado;
        }

    }
}