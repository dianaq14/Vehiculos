using System;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;
using Microsoft.EntityFrameworkCore;


namespace VehiculosTransporte.App.Persistenica
{
    public class RepositorioMecanico :IRepositorioMecanico
    {
        ///<sumary>
        ///Referencia contexto de mecanico
        ///<sumary>

        private readonly AppContext _appContext;
        ///<sumary>
        ///Metodo Constructor
        ///Inyeccion de dependencis para indicar el contexto
        ///<sumary>
        ///<param name "appContext" ></param>//

        public RepositorioMecanico (AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mecanico AddMecanico (Mecanico mecanico)
        {
            var mecanicoAdicionado = _appContext.Mecanico.Add(mecanico);
            _appContext.SaveChanges();
            return mecanicoAdicionado.Entity;
        }
        
        public void DeleteMecanico (int idMecanico)
        {
            var mecanicoEncontrado = _appContext.Mecanicos.FirstOrDefault(d=>d.Id==idMecanico);
            if (mecanicoEncontrado == null)
                return;
            _appContext.Mecanicos.Remove(mecanicoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Mecanico> GetAllMecanicos()
        {
            return GetAllMecanicos_();
        }

        public IEnumerable<Mecanico> GetAllMecanicosPorFiltro(string filtro)
        {
            var mecanicos = GetAllMecanicos(); 
            if(!String.IsNullOrEmpty(filtro))
            {
                mecanicos= mecanicos.Where(s=> s.Nombres.Contains(filtro));
            }
        }

        public Mecanico UpdateDueño (Mecanico mecanico)
        {
            var mecanicoEncontrado =_appContext.Mecanicos.FirstOrDefault(m=>m.Id == mecanico.Id);
            if(mecanicoEncontrado != null)
            {
                mecanicoEncontrado.Nombres = mecanico.Nombres;
                mecanicoEncontrado.Telefono = mecanico.Telefono;
                mecanicoEncontrado.NivelEstudios= mecanico.NivelEstudios;


                _appContext.SaveChanges();
            }
            return mecanicoEncontrado;
        }

    }
}