using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Distribuidora
    {
        [Display(Name ="Distrubuidora")]
        [Required(ErrorMessage = "Campo requerido")]
        public int IdDistribuidora { get; set; }
        public string Nombre { get; set; }
        public List<object> Distribuidoras { get; set; }
    }
}
