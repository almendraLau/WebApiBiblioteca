using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBiblioteca.Models
{
    public class Cartilla
    {
        [Key]
        public int nId { get; set; }
        public string cTitle { get; set; }
        public string cDescription { get; set; }
        public string cPhotography { get; set; }
        public string cTextButton { get; set; }
        public string cLinkButton { get; set; }
    }
}
