using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using Tarea2AlessandroFavareto.Data;
using Tarea2AlessandroFavareto.Models;

namespace Tarea2AlessandroFavareto.Controllers
{

    public class EncuestasController : Controller
    {


        // GET: Encuestas
        public ActionResult Index()
        {
            Dictionary<int, Encuesta> datosSesion = Session["DatosSesion"] as Dictionary<int, Encuesta>;
            
            return View(datosSesion.ToList());
        }

        // GET: Encuestas/Details/5
        /*public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encuesta encuesta = db.Encuestas.Find(id);
            if (encuesta == null)
            {
                return HttpNotFound();
            }
            return View(encuesta);
        }*/

        // GET: Encuestas/Create
        public ActionResult Create()
        {
            var paises = new List<SelectListItem>
            {
                new SelectListItem { Value = "AF", Text = "Afganistán" },
                new SelectListItem { Value = "AL", Text = "Albania" },
                new SelectListItem { Value = "DZ", Text = "Argelia" },
                new SelectListItem { Value = "AD", Text = "Andorra" },
                new SelectListItem { Value = "AO", Text = "Angola" },
                new SelectListItem { Value = "AI", Text = "Anguila" },
                new SelectListItem { Value = "AQ", Text = "Antártida" },
                new SelectListItem { Value = "AG", Text = "Antigua y Barbuda" },
                new SelectListItem { Value = "AR", Text = "Argentina" },
                new SelectListItem { Value = "AM", Text = "Armenia" },
                new SelectListItem { Value = "AW", Text = "Aruba" },
                new SelectListItem { Value = "AU", Text = "Australia" },
                new SelectListItem { Value = "AT", Text = "Austria" },
                new SelectListItem { Value = "AZ", Text = "Azerbaiyán" },
                new SelectListItem { Value = "BS", Text = "Bahamas" },
                new SelectListItem { Value = "BH", Text = "Baréin" },
                new SelectListItem { Value = "BD", Text = "Bangladés" },
                new SelectListItem { Value = "BB", Text = "Barbados" },
                new SelectListItem { Value = "BY", Text = "Bielorrusia" },
                new SelectListItem { Value = "BE", Text = "Bélgica" },
                //... continúa con más países
            };

            ViewBag.Paises = paises;
            return View();
        }

        // POST: Encuestas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Encuesta encuesta)
        {
            
            if (Session["DatosSesion"] == null)
            {
                var datosSesion = new Dictionary<int, Encuesta>();
                datosSesion.Add(0, encuesta);
                Session["DatosSesion"] = datosSesion;
                
            }
            else
            {
                Dictionary<int, Encuesta> datosSesion = Session["DatosSesion"] as Dictionary<int, Encuesta>;
                datosSesion.Add(datosSesion.Count, encuesta);
                Session["DatosSesion"] = datosSesion;

                
            }
            return RedirectToAction("Index");
            


        }
       
    }
}
