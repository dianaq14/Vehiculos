using System; 
namespace Vehiculos.App.Dominio
{
    public class Conductor: Persona
    {
        public string Licencia {get; set;}
        public string CiudadResidencia {get; set;}
        public List <VehiculosTransporte> VehiculoTransporte {get; set;}
    }
}