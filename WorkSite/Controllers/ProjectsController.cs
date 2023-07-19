using System.Web.Mvc;
using LightInject;
using WorkSite.Clients;
using WorkSite.Mappings;
using WorkSite.Models.Projects;
using FluentValidation.Mvc;
using WorkSite.Resources;

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

        [HttpPost]
        public ActionResult AddProject([CustomizeValidator(RuleSet = RuleSets.AddProject)] AddProjectModel project)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_AddProject", project);
            }
            _dataClient.AddProject(project);
            return Json(new { redirectToUrl = Url.Action("Index", "Projects") });
        }

        [HttpGet]
        public ActionResult _AddProject()
        {
            var model = ProjectsMappings.MapToAddProjectModel();
            return View("_AddProject", model);
        }

        [HttpPost]
        public ActionResult RemoveProject(int id)
        {
            return View();
        }
    }
}
