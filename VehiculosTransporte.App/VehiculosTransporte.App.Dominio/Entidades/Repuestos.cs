 using System;
 namespace VehiculosTransporte.App.Dominio
{
    public class Repuestos : Jefe_operaciones 
    {
        public string TipoRepuesto {get; set;}
        public double Valor {get; set;}
        public DateTime FechaCompra {get;set;}
        public string Justificación {get; set;}

    }
}