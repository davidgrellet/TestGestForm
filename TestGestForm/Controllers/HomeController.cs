using System.Collections.Generic;
using System.Web.Mvc;
using TestGestForm.Interfaces;
using TestGestForm.Services;

namespace TestGestForm.Controllers
{
    public class HomeController : Controller
    {
        private IRandNumberService service = new RandNumberService();

        public ActionResult Index()
        {
            ViewData["randNumberList"] = service.GetRandNumberList();
            return View();
        }
        public JsonResult RefreshDatas()
        {
            List<string> response = service.GetRandNumberList();
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}