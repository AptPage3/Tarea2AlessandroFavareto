using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea2AlessandroFavareto.Models
{
    public class Grid
    {
        [Key]
        public int Posicion { get; set; }
        public string Nombre  { get; set; }
        public int Clasificacion { get; set; }
        public string Porcentaje { get; set; }
        
    }
    
}