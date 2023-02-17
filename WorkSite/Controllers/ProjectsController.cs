using System.Web.Mvc;
using LightInject;
using WorkSite.Clients;
using WorkSite.Mappings;
namespace WorkSite.Controllers
{
    public class ProjectsController : Controller
    {
        [Inject]
        public IDataClient _dataClient { get; set; }

        public ActionResult Index()
        {
            var projects = _dataClient.GetProjects();
            var model = ProjectsMappings.MapToProjectsViewModel(projects);
            return View(model);
        }
    }
}
