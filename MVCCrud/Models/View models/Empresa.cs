using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Empresaviewmodels
    {
        public int Id { get; set; }
        public string IdEmpresa { get; set; }  
        public string perNombre { get; set; }
        public string perCorreo { get; set; }
        public string perNit { get; set; }
        

    }
}