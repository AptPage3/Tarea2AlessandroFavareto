using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea2AlessandroFavareto.Models
{
    public class Grid
    {
        public int Posicion { get; set; }
        public string Nombre  { get; set; }
        public string ClasificacionMostrar { get; set; }
        public float Clasificacion { get; set; }
        public float Votos { get; set; }
        public string PorcentajeMostrar { get; set; }
        public float Porcentaje { get; set; }
        

    }
    
}