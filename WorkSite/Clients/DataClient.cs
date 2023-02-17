using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkSite.Clients.Models;
using WorkSite.Clients.Mappings;
namespace WorkSite.Clients
{
    public class DataClient: IDataClient
    {
        public IList<Project> Data { get; set; }

        public DataClient()
        {
            Data = new List<Project>();
            Initialize();
        }
        public void RegisterProjectsData()
        {
            Data.Add(ProjectMappings.MapToProjectModel(1, "Ship Model", "3D Model/Print", ProjectStatus.P1Designing, startDate:DateTime.Parse("11/15/2020")));    
            Data.Add(ProjectMappings.MapToProjectModel(2, "Character Drawing 2", "Drawing", ProjectStatus.Completed, startDate:DateTime.Parse("10/20/2018"), completeDate:DateTime.Parse("10/31/2018")));  
            Data.Add(ProjectMappings.MapToProjectModel(3, "Character Drawing 1", "Drawing", ProjectStatus.Completed, startDate:DateTime.Parse("03/01/2016"), completeDate:DateTime.Parse("03/15/2016")));
            Data.Add(ProjectMappings.MapToProjectModel(4, "Armor Model", "3D Model/Print", ProjectStatus.OnHold, startDate:DateTime.Parse("01/20/2022")));
        }

        public void Initialize()
        {
            RegisterProjectsData();
        }

        public IEnumerable<Project> GetProjects()
        {
            return Data;
        }
    }
}