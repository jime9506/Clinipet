using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Empleadosviewmodels
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string FechaContratacion { get; set; }
        public string TipoContrato { get; set; }
     
    }
}