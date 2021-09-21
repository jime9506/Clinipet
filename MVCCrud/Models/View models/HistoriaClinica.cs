using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.View_models
{
    public class HistoriaClinicaviewmodels
    {
        public int IdMascota { get; set; }
        public string Emfermedades { get; set; }
        public string Vacunas { get; set; }
        public decimal Peso { get; set; }
       
        

    }
}