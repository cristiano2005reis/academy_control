using Academy_Control.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_Control.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            Services.ProfessorService service = new Services.ProfessorService();
            return View(service.ListAll());
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Professores professor)
        {
            Services.ProfessorService service = new Services.ProfessorService();
            service.Add(professor);

            return View(professor);
        }
    }
}