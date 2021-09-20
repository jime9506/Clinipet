using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Personasviewmodels
    {
        public int Id { get; set; }
        [Display(Name = "Cedula")]
        public string perIdentificacion { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombres")]
        public string perNombres { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        public string perApellidos { get; set; }
        [Required]
        [Display(Name = "Genero")]
        public string perGenero { get; set; }
        [Required]
        [Display(Name = "Correo")]
        public string perCorreo { get; set; }
        [Required]
        [Display(Name = "FechaNacimiento")]
        
        public System.DateTime  perFechaNacimiento { get; set; }
        
    }
}