using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tarea2AlessandroFavareto.Models;

namespace Tarea2AlessandroFavareto.Controllers
{
    public class GridsController : Controller
    {
        

        // GET: Grids
        public ActionResult Index()
        {
            
            if (Session["DatosSesion"] == null)
            {
                string[] Nombres =
                    { "C", "C++", "C#", "Java", "Python", "JavaScript", "Ruby",
                    "Swift", "Kotlin", "Rust", "Go", "PHP", "TypeScript", "HTML",
                    "CSS", "SQL", "R", "MATLAB", "Scala", "Perl", "Haskell", "Lua",
                    "Dart", "Assembly", "Objective-C", "Shell", "VB.NET", "COBOL", "Fortran" };
                var Lenguaje = new List< Grid>();
                for (int i = 0; i < 29; i++)
                {
                    Grid grid = new Grid { Posicion = i, Nombre = Nombres[i],Clasificacion = 0, Porcentaje = "0"};
                    Lenguaje.Add(grid);
                }
                return View(Lenguaje);
            }
            return View();
            
        }



    }
}
