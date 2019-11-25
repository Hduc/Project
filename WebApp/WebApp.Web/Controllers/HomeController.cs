using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;
using WebApp.Business;
namespace WebApp.Web.Controllers
{
    public class HomeController : Controller
    {
        //[Dependency] public IProductBusiness productBusiness { get; set; }
        [Dependency] public IAttachmentService attachmentService { get; set; }
        public async Task<ActionResult> Index()
        {
            var id = Guid.NewGuid();
            var rs = await attachmentService.GetById(id);
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
    }
}