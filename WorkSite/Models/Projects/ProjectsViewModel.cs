using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkSite.Models.Projects
{
    public class ProjectsViewModel
    {
        public IList<ProjectModel> Projects { get; set; }

        public ProjectsViewModel()
        {
            Projects = new List<ProjectModel>();
        }
    }
}