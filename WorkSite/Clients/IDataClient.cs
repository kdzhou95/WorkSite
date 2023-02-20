using System.Collections.Generic;
using WorkSite.Clients.Models;
using WorkSite.Models.Projects;

namespace WorkSite.Clients
{
    public interface IDataClient
    {
        void RegisterDefaultData();

        void Initialize();

        string GeneratePreview(string SourceFilePath);

        void AddProject(AddProjectModel addProjectModel);

        IEnumerable<Project> GetProjects();
    }
}