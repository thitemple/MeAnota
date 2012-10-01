using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeAnota.Models
{
    public class Anotacao : BaseEntity
    {
        [Required]
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public Bloco Bloco { get; set; }
    }
}