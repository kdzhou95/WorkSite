using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkSite.Clients.Models;
using WorkSite.Models.Home;

namespace WorkSite.Mappings
{
    public static class HomeMappings
    {
        public static HomeModel MapToHomeModel(IEnumerable<Project> projects)
        {
            return new HomeModel
            {
                Overviews = MapToOverviewProjectsViewModel(projects)
            };
        }
        public static OverviewsViewModel MapToOverviewProjectsViewModel(IEnumerable<Project> projects)
        {
            var overviewsModel = new OverviewsViewModel()
            {
                Overviews = new List<ProjectOverviewModel>()
            };
            foreach (var project in projects){
                overviewsModel.Overviews.Add(MapToProjectOverviewModel(project));
            }

            return overviewsModel;
        }

        public static ProjectOverviewModel MapToProjectOverviewModel(Project project)
        {
            return new ProjectOverviewModel
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                Status = project.Status
            };
        }
    }
}