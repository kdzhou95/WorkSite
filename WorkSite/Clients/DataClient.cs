using System;
using System.Collections.Generic;
using System.Linq;
using WorkSite.Clients.Models;
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

        public void RegisterDefaultData()
        {
            RegisterProject(1, "CVN 80 Ship Model", "3D Model/Print", ProjectStatus.P1Designing, startDate:DateTime.Parse("11/15/2020"));    
            RegisterProject(2, "Character Drawing 2", "Drawing", ProjectStatus.Completed, startDate:DateTime.Parse("10/20/2018"), completeDate:DateTime.Parse("10/31/2018"));  
            RegisterProject(3, "Character Drawing 1", "Drawing", ProjectStatus.Completed, startDate:DateTime.Parse("03/01/2016"), completeDate:DateTime.Parse("03/15/2016"));
            RegisterProject(4, "Armor Model", "3D Model/Print", ProjectStatus.OnHold, startDate:DateTime.Parse("01/20/2022"));
        }

        public void RegisterProject(int id, string name, string type, string status, DateTime? startDate = null, DateTime? completeDate = null)
        {
            Data.Add(new Project
            {
                Id = id,
                Name = name,
                Type = type,   
                Status = status,
                StartDate = startDate,
                CompleteDate = completeDate
            });
        }

        public void RemoveProject(int id)
        {
            var target = Data.SingleOrDefault(x => x.Id == id);
            Data.Remove(target);
        }

        public void Initialize()
        {
            RegisterDefaultData();
        }

        public IEnumerable<Project> GetProjects()
        {
            return Data;
        }
    }
}