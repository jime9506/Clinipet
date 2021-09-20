using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class Rolesviewmodels
    {
        public int Id { get; set; }
        public string IdRol { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "IdRol")]
        public string Rol { get; set; }
       

    }
}