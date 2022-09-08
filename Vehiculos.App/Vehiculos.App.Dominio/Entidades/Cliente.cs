using System; 
namespace Vehiculos.App.Dominio
{
     public class cliente: Persona
    {
        public int id{get; set;}
        public List <Servicios> Servicio {get; set;}

    }
}