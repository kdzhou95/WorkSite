using FluentValidation.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using WorkSite.Validation.Projects;
namespace WorkSite.Models.Projects
{
    [Validator(typeof(AddProjectValidator))]
    public class AddProjectModel
    {
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        public string Specifications { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Complete Date")]
        public DateTime? CompleteDate { get; set; }

        public string SourceFilePath { get; set; }
    }
}