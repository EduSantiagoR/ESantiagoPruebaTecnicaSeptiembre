using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Artista
    {
        [Display(Name = "Artista")]
        [Required(ErrorMessage = "Campo requerido")]
        public int IdArtista { get; set; }
        public string NombreArtistico { get; set; }
        public List<object> Artistas { get; set; }
    }
}
