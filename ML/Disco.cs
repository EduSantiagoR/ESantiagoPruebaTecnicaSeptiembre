using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Disco
    {
        public int IdDisco { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Titulo { get; set; }
        public ML.Artista Artista { get; set; }
        public ML.GeneroMusical GeneroMusical { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Duracion { get; set; }
        [Display(Name = "Año")]
        [Required(ErrorMessage = "Campo requerido")]
        public DateTime Anio { get; set; }
        public ML.Distribuidora Distribuidora { get; set; }
        public int Ventas { get; set; }
        public bool Disponibilidad { get; set; }
        public List<object> Discos { get; set; }
    }
}
