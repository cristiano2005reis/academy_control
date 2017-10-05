using Academy_Control.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_Control.Controllers
{
    public class ModalidadeController : Controller
    {
        // GET: Modalidade
        public ActionResult Index()
        {
            Services.ModalidadeService service = new Services.ModalidadeService();
            return View(service.ListAll());
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Modalidades modalidade)
        {
            Services.ModalidadeService service = new Services.ModalidadeService();
            service.Add(modalidade);

            return View(modalidade);
        }

    }
}