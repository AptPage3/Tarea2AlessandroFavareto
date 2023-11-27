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

    public class EncuestasController : Controller
    {


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
                new SelectListItem { Value = "BZ", Text = "Belice" },
                new SelectListItem { Value = "BJ", Text = "Benín" },
                new SelectListItem { Value = "BM", Text = "Bermudas" },
                new SelectListItem { Value = "BT", Text = "Bután" },
                new SelectListItem { Value = "BO", Text = "Bolivia" },
                new SelectListItem { Value = "BA", Text = "Bosnia y Herzegovina" },
                new SelectListItem { Value = "BW", Text = "Botsuana" },
                new SelectListItem { Value = "BR", Text = "Brasil" },
                new SelectListItem { Value = "BN", Text = "Brunéi" },
                new SelectListItem { Value = "BG", Text = "Bulgaria" },
                new SelectListItem { Value = "BF", Text = "Burkina Faso" },
                new SelectListItem { Value = "BI", Text = "Burundi" },
                new SelectListItem { Value = "KH", Text = "Camboya" },
                new SelectListItem { Value = "CM", Text = "Camerún" },
                new SelectListItem { Value = "CA", Text = "Canadá" },
                new SelectListItem { Value = "CV", Text = "Cabo Verde" },
                new SelectListItem { Value = "KY", Text = "Islas Caimán" },
                new SelectListItem { Value = "CF", Text = "República Centroafricana" },
                new SelectListItem { Value = "TD", Text = "Chad" },
                new SelectListItem { Value = "CL", Text = "Chile" },
                new SelectListItem { Value = "CN", Text = "China" },
                new SelectListItem { Value = "CO", Text = "Colombia" },
                new SelectListItem { Value = "KM", Text = "Comoras" },
                new SelectListItem { Value = "CG", Text = "Congo" },
                new SelectListItem { Value = "CD", Text = "República Democrática del Congo" },
                new SelectListItem { Value = "CR", Text = "Costa Rica" },
                new SelectListItem { Value = "CI", Text = "Costa de Marfil" },
                new SelectListItem { Value = "HR", Text = "Croacia" },
                new SelectListItem { Value = "CU", Text = "Cuba" },
                new SelectListItem { Value = "CY", Text = "Chipre" },
                new SelectListItem { Value = "CZ", Text = "República Checa" },
                new SelectListItem { Value = "DK", Text = "Dinamarca" },
                new SelectListItem { Value = "DJ", Text = "Yibuti" },
                new SelectListItem { Value = "DM", Text = "Dominica" },
                new SelectListItem { Value = "DO", Text = "República Dominicana" },
                new SelectListItem { Value = "EC", Text = "Ecuador" },
                new SelectListItem { Value = "EG", Text = "Egipto" },
                new SelectListItem { Value = "SV", Text = "El Salvador" },
                new SelectListItem { Value = "GQ", Text = "Guinea Ecuatorial" },
                new SelectListItem { Value = "ER", Text = "Eritrea" },
                new SelectListItem { Value = "EE", Text = "Estonia" },
                new SelectListItem { Value = "ET", Text = "Etiopía" },
                new SelectListItem { Value = "FJ", Text = "Fiyi" },
                new SelectListItem { Value = "FI", Text = "Finlandia" },
                new SelectListItem { Value = "FR", Text = "Francia" },
                new SelectListItem { Value = "GA", Text = "Gabón" },
                new SelectListItem { Value = "GM", Text = "Gambia" },
                new SelectListItem { Value = "GE", Text = "Georgia" },
                new SelectListItem { Value = "DE", Text = "Alemania" },
                new SelectListItem { Value = "GH", Text = "Ghana" },
                new SelectListItem { Value = "GR", Text = "Grecia" },
                new SelectListItem { Value = "GD", Text = "Granada" },
                new SelectListItem { Value = "GT", Text = "Guatemala" },
                new SelectListItem { Value = "GN", Text = "Guinea" },
                new SelectListItem { Value = "GW", Text = "Guinea-Bisáu" },
                new SelectListItem { Value = "GY", Text = "Guyana" },
                new SelectListItem { Value = "HT", Text = "Haití" },
                new SelectListItem { Value = "HN", Text = "Honduras" },
                new SelectListItem { Value = "HU", Text = "Hungría" },
                new SelectListItem { Value = "IS", Text = "Islandia" },
                new SelectListItem { Value = "IN", Text = "India" },
                new SelectListItem { Value = "ID", Text = "Indonesia" },
                new SelectListItem { Value = "IR", Text = "Irán" },
                new SelectListItem { Value = "IQ", Text = "Irak" },
                new SelectListItem { Value = "IE", Text = "Irlanda" },
                new SelectListItem { Value = "IL", Text = "Israel" },
                new SelectListItem { Value = "IT", Text = "Italia" },
                new SelectListItem { Value = "JM", Text = "Jamaica" },
                new SelectListItem { Value = "JP", Text = "Japón" },
                new SelectListItem { Value = "JO", Text = "Jordania" },
                new SelectListItem { Value = "KZ", Text = "Kazajistán" },
                new SelectListItem { Value = "KE", Text = "Kenia" },
                new SelectListItem { Value = "KI", Text = "Kiribati" },
                new SelectListItem { Value = "KP", Text = "Corea del Norte" },
                new SelectListItem { Value = "KR", Text = "Corea del Sur" },
                new SelectListItem { Value = "KW", Text = "Kuwait" },
                new SelectListItem { Value = "KG", Text = "Kirguistán" },
                new SelectListItem { Value = "LA", Text = "Laos" },
                new SelectListItem { Value = "LV", Text = "Letonia" },
                new SelectListItem { Value = "LB", Text = "Líbano" },
                new SelectListItem { Value = "LS", Text = "Lesoto" },
                new SelectListItem { Value = "LR", Text = "Liberia" },
                new SelectListItem { Value = "LY", Text = "Libia" },
                new SelectListItem { Value = "LI", Text = "Liechtenstein" },
                new SelectListItem { Value = "LT", Text = "Lituania" },
                new SelectListItem { Value = "LU", Text = "Luxemburgo" },
                new SelectListItem { Value = "MK", Text = "Macedonia del Norte" },
                new SelectListItem { Value = "MG", Text = "Madagascar" },
                new SelectListItem { Value = "MW", Text = "Malaui" },
                new SelectListItem { Value = "MY", Text = "Malasia" },
                new SelectListItem { Value = "MV", Text = "Maldivas" },
                new SelectListItem { Value = "ML", Text = "Malí" },
                new SelectListItem { Value = "MT", Text = "Malta" },
                new SelectListItem { Value = "MH", Text = "Islas Marshall" },
                new SelectListItem { Value = "MR", Text = "Mauritania" },
                new SelectListItem { Value = "MU", Text = "Mauricio" },
                new SelectListItem { Value = "MX", Text = "México" },
                new SelectListItem { Value = "FM", Text = "Micronesia" },
                new SelectListItem { Value = "MD", Text = "Moldavia" },
                new SelectListItem { Value = "MC", Text = "Mónaco" },
                new SelectListItem { Value = "MN", Text = "Mongolia" },
                new SelectListItem { Value = "ME", Text = "Montenegro" },
                new SelectListItem { Value = "MA", Text = "Marruecos" },
                new SelectListItem { Value = "MZ", Text = "Mozambique" },
                new SelectListItem { Value = "MM", Text = "Myanmar" },
                new SelectListItem { Value = "NA", Text = "Namibia" },
                new SelectListItem { Value = "NR", Text = "Nauru" },
                new SelectListItem { Value = "NP", Text = "Nepal" },
                new SelectListItem { Value = "NL", Text = "Países Bajos" },
                new SelectListItem { Value = "NZ", Text = "Nueva Zelanda" },
                new SelectListItem { Value = "NI", Text = "Nicaragua" },
                new SelectListItem { Value = "NE", Text = "Níger" },
                new SelectListItem { Value = "NG", Text = "Nigeria" },
                new SelectListItem { Value = "NO", Text = "Noruega" },
                new SelectListItem { Value = "OM", Text = "Omán" },
                new SelectListItem { Value = "PK", Text = "Pakistán" },
                new SelectListItem { Value = "PW", Text = "Palaos" },
                new SelectListItem { Value = "PS", Text = "Palestina" },
                new SelectListItem { Value = "PA", Text = "Panamá" },
                new SelectListItem { Value = "PG", Text = "Papúa Nueva Guinea" },
                new SelectListItem { Value = "PY", Text = "Paraguay" },
                new SelectListItem { Value = "PE", Text = "Perú" },
                new SelectListItem { Value = "PH", Text = "Filipinas" },
                new SelectListItem { Value = "PL", Text = "Polonia" },
                new SelectListItem { Value = "PT", Text = "Portugal" },
                new SelectListItem { Value = "QA", Text = "Catar" },
                new SelectListItem { Value = "RO", Text = "Rumanía" },
                new SelectListItem { Value = "RU", Text = "Rusia" },
                new SelectListItem { Value = "RW", Text = "Ruanda" },
                new SelectListItem { Value = "KN", Text = "San Cristóbal y Nieves" },
                new SelectListItem { Value = "LC", Text = "Santa Lucía" },
                new SelectListItem { Value = "VC", Text = "San Vicente y las Granadinas" },
                new SelectListItem { Value = "WS", Text = "Samoa" },
                new SelectListItem { Value = "SM", Text = "San Marino" },
                new SelectListItem { Value = "ST", Text = "Santo Tomé y Príncipe" },
                new SelectListItem { Value = "SA", Text = "Arabia Saudita" },
                new SelectListItem { Value = "SN", Text = "Senegal" },
                new SelectListItem { Value = "RS", Text = "Serbia" },
                new SelectListItem { Value = "SC", Text = "Seychelles" },
                new SelectListItem { Value = "SL", Text = "Sierra Leona" },
                new SelectListItem { Value = "SG", Text = "Singapur" },
                new SelectListItem { Value = "SK", Text = "Eslovaquia" },
                new SelectListItem { Value = "SI", Text = "Eslovenia" },
                new SelectListItem { Value = "SB", Text = "Islas Salomón" },
                new SelectListItem { Value = "SO", Text = "Somalia" },
                new SelectListItem { Value = "ZA", Text = "Sudáfrica" },
                new SelectListItem { Value = "SS", Text = "Sudán del Sur" },
                new SelectListItem { Value = "ES", Text = "España" },
                new SelectListItem { Value = "LK", Text = "Sri Lanka" },
                new SelectListItem { Value = "SD", Text = "Sudán" },
                new SelectListItem { Value = "SR", Text = "Surinam" },
                new SelectListItem { Value = "SZ", Text = "Esuatini" },
                new SelectListItem { Value = "SE", Text = "Suecia" },
                new SelectListItem { Value = "CH", Text = "Suiza" },
                new SelectListItem { Value = "SY", Text = "Siria" },
                new SelectListItem { Value = "TW", Text = "Taiwán" },
                new SelectListItem { Value = "TJ", Text = "Tayikistán" },
                new SelectListItem { Value = "TZ", Text = "Tanzania" },
                new SelectListItem { Value = "TZ", Text = "Tanzania" },
                new SelectListItem { Value = "TH", Text = "Tailandia" },
                new SelectListItem { Value = "TL", Text = "Timor Oriental" },
                new SelectListItem { Value = "TG", Text = "Togo" },
                new SelectListItem { Value = "TK", Text = "Tokelau" },
                new SelectListItem { Value = "TO", Text = "Tonga" },
                new SelectListItem { Value = "TT", Text = "Trinidad y Tobago" },
                new SelectListItem { Value = "TN", Text = "Túnez" },
                new SelectListItem { Value = "TR", Text = "Turquía" },
                new SelectListItem { Value = "TM", Text = "Turkmenistán" },
                new SelectListItem { Value = "TC", Text = "Islas Turks y Caicos" },
                new SelectListItem { Value = "TV", Text = "Tuvalu" },
                new SelectListItem { Value = "UG", Text = "Uganda" },
                new SelectListItem { Value = "UA", Text = "Ucrania" },
                new SelectListItem { Value = "AE", Text = "Emiratos Árabes Unidos" },
                new SelectListItem { Value = "GB", Text = "Reino Unido" },
                new SelectListItem { Value = "US", Text = "Estados Unidos" },
                new SelectListItem { Value = "UM", Text = "Islas menores alejadas de los Estados Unidos" },
                new SelectListItem { Value = "UY", Text = "Uruguay" },
                new SelectListItem { Value = "UZ", Text = "Uzbekistán" },
                new SelectListItem { Value = "VU", Text = "Vanuatu" },
                new SelectListItem { Value = "VE", Text = "Venezuela" },
                new SelectListItem { Value = "VN", Text = "Vietnam" },
                new SelectListItem { Value = "VG", Text = "Islas Vírgenes Británicas" },
                new SelectListItem { Value = "VI", Text = "Islas Vírgenes de los Estados Unidos" },
                new SelectListItem { Value = "WF", Text = "Wallis y Futuna" },
                new SelectListItem { Value = "EH", Text = "Sahara Occidental" },
                new SelectListItem { Value = "YE", Text = "Yemen" },
                new SelectListItem { Value = "ZM", Text = "Zambia" },
                new SelectListItem { Value = "ZW", Text = "Zimbabue" }
            };
            var roles = new List<SelectListItem>
            {
                new SelectListItem { Value = "Programador Front-end", Text = "Programador Front-end" },
                new SelectListItem { Value = "Programador Back-end", Text = "Programador Back-end" },
                new SelectListItem { Value = "Analista de sistemas", Text = "Analista de sistemas" },
                new SelectListItem { Value = "Diseñador gráfico", Text = "Diseñador gráfico" },
                new SelectListItem { Value = "Administrador de proyectos de TI", Text = "Administrador de proyectos de TI" },
            };
            var lenguajes = new List<SelectListItem>
            {
                new SelectListItem { Value = "Ada", Text = "Ada" },
                new SelectListItem { Value = "Assembly", Text = "Assembly" },
                new SelectListItem { Value = "C", Text = "C" },
                new SelectListItem { Value = "C#", Text = "C#" },
                new SelectListItem { Value = "C++", Text = "C++" },
                new SelectListItem { Value = "Cobol", Text = "Cobol" },
                new SelectListItem { Value = "Dart", Text = "Dart" },
                new SelectListItem { Value = "Fortran", Text = "Fortran" },
                new SelectListItem { Value = "GDScript", Text = "GDScript" },
                new SelectListItem { Value = "GameMaker Language", Text = "GameMaker Language" },
                new SelectListItem { Value = "Go", Text = "Go" },
                new SelectListItem { Value = "Groovy", Text = "Groovy" },
                new SelectListItem { Value = "Haskell", Text = "Haskell" },
                new SelectListItem { Value = "Java", Text = "Java" },
                new SelectListItem { Value = "JavaScript", Text = "JavaScript" },
                new SelectListItem { Value = "Julia", Text = "Julia" },
                new SelectListItem { Value = "Kotlin", Text = "Kotlin" },
                new SelectListItem { Value = "Lua", Text = "Lua" },
                new SelectListItem { Value = "MATLAB", Text = "MATLAB" },
                new SelectListItem { Value = "Objective-C", Text = "Objective-C" },
                new SelectListItem { Value = "Perl", Text = "Perl" },
                new SelectListItem { Value = "PHP", Text = "PHP" },
                new SelectListItem { Value = "Python", Text = "Python" },
                new SelectListItem { Value = "R", Text = "R" },
                new SelectListItem { Value = "Ruby", Text = "Ruby" },
                new SelectListItem { Value = "Rust", Text = "Rust" },
                new SelectListItem { Value = "Scala", Text = "Scala" },
                new SelectListItem { Value = "Swift", Text = "Swift" },
                new SelectListItem { Value = "TypeScript", Text = "TypeScript" },
                new SelectListItem { Value = "Visual Basic", Text = "Visual Basic" }

            };

            ViewBag.Paises = paises;
            ViewBag.Roles = roles;
            ViewBag.Lenguajes = lenguajes;
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
                var datosSesion = new Dictionary<int, Encuesta>
                {
                    { 0, encuesta }
                };
                Session["DatosSesion"] = datosSesion;

            }
            else
            {
                Dictionary<int, Encuesta> datosSesion = Session["DatosSesion"] as Dictionary<int, Encuesta>;
                datosSesion.Add(datosSesion.Count, encuesta);
                Session["DatosSesion"] = datosSesion;

            }

            return RedirectToAction("Index","Grids");
            


        }
       
    }
}
