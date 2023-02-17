﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkSite.Mappings;
using LightInject;
using WorkSite.Clients;
namespace WorkSite.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IDataClient _dataClient { get; set; }

        public ActionResult Index()
        {
            var projects = _dataClient.GetProjects();
            var overviewsModel = HomeMappings.MapToHomeModel(projects);
            return View();
        }

        public ActionResult _ProjectsOverview()
        {
            var projects = _dataClient.GetProjects();
            var overviewsModel = HomeMappings.MapToOverviewProjectsViewModel(projects);
            return View(overviewsModel);
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