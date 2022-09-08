using System;
namespace Vehiculos.App.Dominio
{
    public class VehiculosTransporte
    {
        public int placa{get; set;}
        public string marca {get; set;}
        public string modelo_año {get; set;}
        public string tipo {get; set;}
        public string CapacidadPasajeros {get; set; }
        public string PaisOrigen {get; set;}
        public int cilindraje_motor {get; set;}
        public Duenio duenios {get; set;}
        public Conductor Conductores {get; set;}
        
    }    
}