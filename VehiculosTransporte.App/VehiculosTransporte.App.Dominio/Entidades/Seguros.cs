using System;
namespace VehiculosTransporte.App.Dominio
{
    public class Seguros : Transporte
    {
         public DateTime Soat {get; set;}
         public DateTime seguro_contractual {get; set;}
         public DateTime seguro_extracontractual {get; set;}
    }
}