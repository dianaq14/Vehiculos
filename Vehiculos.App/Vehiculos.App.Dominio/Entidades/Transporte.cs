using System;
namespace VehiculosTransporte.App.Dominio
{
    public class Transporte : Persona
    {
        public int placa{get; set;}
        public string marca {get; set;}
        public string modelo_año {get; set;}
        public string tipo {get; set;}
        public string CapacidadPasajeros {get; set; }
        public string PaisOrigen {get; set;}
        public Dueno Dueno {get; set;}
        public Mecanico Mecanico {get; set;}
        public Conductor Conductor {get; set;}
        public int cilindraje_motor {get; set;}
    }    
}