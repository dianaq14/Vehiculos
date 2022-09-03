 using System;
 namespace VehiculosTransporte.App.Dominio
{
    public class Revisiones_vehiculo : Transporte
    {
        public string NivelAceite {get; set;}
        public string RevisionTecnicoMecanica {get; set;}
        public string NivelLiquidoFrenos {get; set;}
        public string NivelRefrigerante {get; set;}
        public string NivelLiquidoDireccion {get; set;}
    }
    
}
 