using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class GeneroMusical
    {
        [Display(Name = "Género")]
        [Required(ErrorMessage = "Campo requerido")]
        public int IdGeneroMusical { get; set; }
        public string Nombre { get; set; }
        public List<object> GenerosMusicales { get; set; }
    }
}
