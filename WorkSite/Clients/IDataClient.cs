using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkSite.Clients.Models;

namespace WorkSite.Clients
{
    public interface IDataClient
    {
        void RegisterProjectsData();
        void Initialize();
        IEnumerable<Project> GetProjects(); 
    }
}