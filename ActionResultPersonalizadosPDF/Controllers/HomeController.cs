using ActionResultPersonalizadosPDF.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultPersonalizadosPDF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CrearPDF(string stream, string text) {
            //PdfFileResult objeto = new PdfFileResult(stream,text)

            return new PdfFileResult(stream,text);
        }
    }
}