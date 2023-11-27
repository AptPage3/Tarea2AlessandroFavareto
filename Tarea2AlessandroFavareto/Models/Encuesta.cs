using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea2AlessandroFavareto.Models
{
    public class Encuesta
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Roles { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string LenguajePrimario { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string LenguajeSecundario { get; set; }


    }
}