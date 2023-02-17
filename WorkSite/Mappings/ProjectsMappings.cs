using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkSite.Clients.Models;
using WorkSite.Models.Projects;

namespace WorkSite.Mappings
{
    public static class ProjectsMappings
    {
        public static ProjectsViewModel MapToProjectsViewModel(IEnumerable<Project> projectsList)
        {
            var projects = new List<ProjectModel>();
            foreach (var project in projectsList)
            {
                projects.Add(new ProjectModel
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    Specifications = project.Specifications,
                    Type = project.Type,
                    Status = project.Status,
                    StartDate = project.StartDate,
                    CompleteDate = project.CompleteDate,
                    PreviewPath = project.PreviewPath,
                });
            }

            return new ProjectsViewModel()
            {
                Projects = projects
            };
        }
    }
}