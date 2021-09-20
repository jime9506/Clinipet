using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Usuariosviewmodels
    {
        public int Id { get; set; }
        public string perNombres { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string perCedula { get; set; }
        [Required]
        [Display(Name = "Cedula")]
        public string perApellidos { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string perGenero { get; set; }
        [Required]
        [Display(Name = "Genero")]
        public string perCorreo { get; set; }
     
    }
}