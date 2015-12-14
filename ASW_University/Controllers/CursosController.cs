using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASW_University.DAL;
using ASW_University.Models;

namespace ASW_University.Controllers
{
    public class CursosController : Controller
    {

        private IUniversityContext db = new UniversityContext();

        public CursosController() { }

        public CursosController(IUniversityContext context)
        {
            db = context;
        }

        // GET: /Cursos/
        public ActionResult Cursos()
        {
            return View(db.Cursos.ToList());
        }


        
	}
}