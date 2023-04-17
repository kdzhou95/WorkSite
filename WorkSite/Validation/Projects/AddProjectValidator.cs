using FluentValidation;
using WorkSite.Resources;
using WorkSite.Models.Projects;

namespace WorkSite.Validation.Projects
{
    public class AddProjectValidator : AbstractValidator<AddProjectModel>
    {
        public AddProjectValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleSet(RuleSets.AddProject, () =>
            {
                RuleFor(m => m.ProjectName)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Name must not be empty");

                RuleFor(m => m.Type)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Type must not be empty");

                RuleFor(m => m.Status)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Status must not be empty");

                RuleFor(m => m.StartDate)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Start date must not be empty");

                RuleFor(m => m.SourceFilePath)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("A file must be uploaded");
            });
        }
    }
}