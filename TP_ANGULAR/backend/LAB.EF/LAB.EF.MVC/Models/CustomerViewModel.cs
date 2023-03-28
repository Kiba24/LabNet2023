using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB.EF.MVC.Models
{
    public class CustomerViewModel
    {
        [Required]
        [StringLength(5, ErrorMessage ="El campo ID puede tener un maximo de 5 caracteres")]
        public string id { get; set; }
        [Required(ErrorMessage = "El campo compania no puede ser nulo")]
        public string Compania { get; set; }
        [Required (ErrorMessage = "El campo ciudad no puede ser nulo")]
        public string ciudad { get; set; }
    }
}