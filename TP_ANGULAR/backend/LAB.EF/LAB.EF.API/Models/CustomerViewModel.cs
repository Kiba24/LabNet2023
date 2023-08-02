using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB.EF.API.Models
{
    public class CustomerViewModel
    {

        [Required]
        [StringLength(5)]
        [MinLength(1)]
        public string id { get; set; }
        [Required]
        [MinLength(1)]
        public string Compania { get; set; }
        [Required]
        [MinLength(1)]
        public string ciudad { get; set; }
    }
}