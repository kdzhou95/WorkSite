using System.Collections.Generic;
using WorkSite.Clients.Models;

namespace WorkSite.Clients
{
    public interface IDataClient
    {
        void RegisterDefaultData();
        void Initialize();
        IEnumerable<Project> GetProjects();
    }
}