using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioSITHEC.Models
{
    public class Humano
    {
        
        public int Id{ get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public double Altura { get; set; }
        [Required]
        public double Peso { get; set; }

    }
}
