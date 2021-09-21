using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Usuarioviewmodels
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "IdRol")]
        public int IdRol{ get; set; }
        [Required]
        [Display(Name = "IdPersona")]
        public int IdPersona { get; set; }
       
    }
}