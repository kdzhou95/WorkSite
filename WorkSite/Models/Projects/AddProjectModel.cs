using System;
using System.ComponentModel.DataAnnotations;

namespace WorkSite.Models.Projects
{
    public class AddProjectModel
    {
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        public string Specifications { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        [Display(Name = "Start Name")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Complete Name")]
        public DateTime? CompleteDate { get; set; }

        public string SourceFilePath { get; set; }
    }
}