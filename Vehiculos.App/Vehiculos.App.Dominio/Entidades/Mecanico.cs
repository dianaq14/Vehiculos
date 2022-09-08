using System;
namespace Vehiculos.App.Dominio

{
    public class Mecanico: Persona
    {
        public string NivelEstudios {get; set;}
        public List <VehiculosTransporte> VehiculosTransporte {get; set;}
         

    }
}
