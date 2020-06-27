using ExportToExcelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExportToExcelDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TechnologyViewModel model = new TechnologyViewModel();
            return View(model);
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

        [HttpGet]
        public FileContentResult ExportToExcel()
        {


            List<Technology> technologies = StaticData.Technologies;
            Dictionary<string, string> col = new Dictionary<string, string>();
            col.Add("Name", "NAME");
            col.Add("Project", "PROJECT");
            col.Add("Developer", "DEVELOPER");
            byte[] filecontent = ExcelExportHelper.ExportExcel(technologies, col, "Technology", true);
            return File(filecontent, ExcelExportHelper.ExcelContentType, "Technologies.xlsx");
        }

    }
}