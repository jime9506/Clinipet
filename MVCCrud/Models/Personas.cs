//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCCrud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personas
    {
        public int IdPersona { get; set; }
        public string perIdentificacion { get; set; }
        public string perNombres { get; set; }
        public string perApellidos { get; set; }
        public string perGenero { get; set; }
        public string perCorreo { get; set; }
        public Nullable<System.DateTime> perFechaNacimiento { get; set; }
    }
}
