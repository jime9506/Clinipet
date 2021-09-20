using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Mascotasviewmodels
    {
        public int IdMascota { get; set; }
        public string Categoria { get; set; }  
        public string NombreMascota { get; set; }   
        public string Telefono { get; set; }
        public string Raza { get; set; }
     
        public string Edad { get; set; }
       
        public string Sexo{ get; set; }
        public string Acudiente { get; set; }
   


    }
}