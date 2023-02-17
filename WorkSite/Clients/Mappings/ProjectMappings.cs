using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkSite.Clients.Models;

namespace WorkSite.Clients.Mappings
{
    public class ProjectMappings
    {
        public static Project MapToProjectModel(int id, string name, string type, string status, DateTime? startDate = null, DateTime? completeDate = null)
        {
            return new Project
            {
                Id = id,
                Name = name,
                Type = type,   
                Status = status,
                StartDate = startDate,
                CompleteDate = completeDate
            };
        }
    }
}