namespace ItWorks.Web.Controllers
{
    using System.Web.Mvc;
    
    using Logic;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new DocumentViewModel());
        }

        [HttpPost]
        public ActionResult Index(DocumentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var documentLogic = new DocumentLogic();

                model.Output = documentLogic.ProcessDocument(model);
            }

            return View(model);
        }
    }
}