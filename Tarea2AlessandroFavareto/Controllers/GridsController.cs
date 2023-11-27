using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using Tarea2AlessandroFavareto.Models;

namespace Tarea2AlessandroFavareto.Controllers
{
    public class GridsController : Controller
    {
        

        // GET: Grids
        public ActionResult Index()
        {
            var Lenguaje = new List<Grid>();
            if (Session["DatosSesion"] == null)
            {
                string[] Nombres ={
                    "C", "C++", "C#", "Java", "Python", "JavaScript", "Ruby",
                    "Swift", "Kotlin", "Rust", "Go", "PHP", "TypeScript", "HTML",
                    "CSS", "SQL", "R", "MATLAB", "Scala", "Perl", "Haskell", "Lua",
                    "Dart", "Assembly", "Objective-C", "Shell", "VB.NET", "COBOL", "Fortran"
                };
                for (int i = 0; i < Nombres.Length; i++)
                {
                    Grid grid = new Grid { Posicion = i + 1, Nombre = Nombres[i], ClasificacionMostrar = "0%", PorcentajeMostrar = "0%" };
                    Lenguaje.Add(grid);
                }
                Session["ListaLenguajes"] = Lenguaje;
                var listaOrdenada = Lenguaje.OrderBy(item => item.Clasificacion).Take(20).ToList();
                return View(listaOrdenada);
            }
            else
            {
                /*int VotosTotales = int.Parse(Session["VotosTotales"].ToString());
                Session["VotosTotales"] = VotosTotales++;*/

                Dictionary<int, Encuesta> datosSesion = Session["DatosSesion"] as Dictionary<int, Encuesta>;
                List<Grid> ListaLenguajes = Session["ListaLenguajes"] as List<Grid>;
                string L1 = datosSesion[datosSesion.Count-1].LenguajePrimario;
                string L2 = datosSesion[datosSesion.Count-1].LenguajeSecundario;
                float VotosTotales = 0; 
                foreach (var item in ListaLenguajes)
                {
                    if (L1.Equals(item.Nombre))
                    {
                        item.Votos += 1;
                        
                    }
                    if (L2.Equals(item.Nombre))
                    {
                        item.Votos += .5f;   
                    }
                    VotosTotales += item.Votos;
                }
                foreach (var item in ListaLenguajes)
                {
                    float num = ((item.Votos / VotosTotales) * 100);
                    item.ClasificacionMostrar = num.ToString() + "%";
                    item.Clasificacion = num;
                }
                var listaOrdenada = ListaLenguajes.OrderByDescending(item => item.Clasificacion).ToList();
                int pos = 1;
                foreach (var item in listaOrdenada)
                {

                    item.Posicion = pos;
                    pos++; 
                }
                for (int i = 0; i < listaOrdenada.Count-1; i++)
                {
                    listaOrdenada[i].Porcentaje = listaOrdenada[i].Clasificacion-listaOrdenada[i+1].Clasificacion;
                    if (listaOrdenada[i].Porcentaje>0)
                    {
                        listaOrdenada[i].PorcentajeMostrar = "+" + listaOrdenada[i].Porcentaje + "%";
                    }

                }
  
                listaOrdenada = ListaLenguajes.OrderByDescending(item => item.Clasificacion).Take(20).ToList();
                return View(listaOrdenada);
            }
            
            

            
        }



    }
}
