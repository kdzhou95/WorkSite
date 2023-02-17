using LightInject;
using System.Web.Mvc;
using WorkSite.Clients;
using WorkSite.Mappings;
namespace WorkSite.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IDataClient _dataClient { get; set; }

        public ActionResult Index()
        {
            var projects = _dataClient.GetProjects();
            var model = HomeMappings.MapToHomeModel(projects);
            return View(model);
        }

        public ActionResult _ProjectsOverview()
        {
            var projects = _dataClient.GetProjects();
            var model = HomeMappings.MapToOverviewProjectsViewModel(projects);
            return View(model);
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Projects page.";

            return RedirectToAction("Index", "Projects");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}