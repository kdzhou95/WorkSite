using System;
using System.Collections.Generic;
using System.Linq;
using WorkSite.Clients.Models;
using WorkSite.Models.Projects;

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
            RegisterProject(1, "CVN 80 Ship Model", "3D Model/Print", ProjectStatus.P1Designing, "C:/Users/kdzhou/source/repos/WorkSite/WorkSite/Media/CVN80.png", startDate:DateTime.Parse("11/15/2020"));    
            RegisterProject(2, "Character Drawing 2", "Drawing", ProjectStatus.Completed, "C:/Users/kdzhou/source/repos/WorkSite/WorkSite/Media/Character Model 2.png", startDate:DateTime.Parse("10/20/2018"), completeDate:DateTime.Parse("10/31/2018"));  
            RegisterProject(3, "Character Drawing 1", "Drawing", ProjectStatus.Completed, "C:/Users/kdzhou/source/repos/WorkSite/WorkSite/Media/Character Model 1.png", startDate:DateTime.Parse("03/01/2016"), completeDate:DateTime.Parse("03/15/2016"));
            RegisterProject(4, "Spear Model", "3D Model/Print", ProjectStatus.OnHold, "C:/Users/kdzhou/source/repos/WorkSite/WorkSite/Media/Siluria's Spear.png", startDate:DateTime.Parse("01/20/2022"));
        }

        public void RegisterProject(int id, string name, string type, string status, string previewPath, DateTime? startDate = null, DateTime? completeDate = null)
        {
            Data.Add(new Project
            {
                Id = id,
                Name = name,
                Type = type,   
                Status = status,
                StartDate = startDate,
                CompleteDate = completeDate,
                PreviewPath = previewPath
            });
        }

        public void RegisterProject(AddProjectModel addProjectModel, int availableId, string previewPath)
        {
            Data.Add(new Project
            {
                Id = availableId,
                Name = addProjectModel.Name,
                Description = addProjectModel.Description,
                Specifications = addProjectModel.Specifications,
                Type = addProjectModel.Type,
                Status = addProjectModel.Status,
                StartDate = addProjectModel.StartDate,
                CompleteDate = addProjectModel.CompleteDate,
                SourceFilePath = addProjectModel.SourceFilePath,
                PreviewPath = previewPath
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

        public string GeneratePreview(string filePath)
        {
            return filePath;
        }

        public void AddProject(AddProjectModel addProjectModel)
        {
            int availableId = Data.OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0;
            var previewPath = GeneratePreview(addProjectModel.SourceFilePath);

            RegisterProject(addProjectModel, availableId, previewPath);
        }
    }
}