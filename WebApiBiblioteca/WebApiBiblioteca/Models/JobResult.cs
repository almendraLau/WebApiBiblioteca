using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBiblioteca.Models
{
    public class JobResult
    {
        public int nEstado { get; set; }
        public string cMensaje { get; set; }
        public Object data { get; set; }
    }
}
