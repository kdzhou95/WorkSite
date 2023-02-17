using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkSite.Models.Home
{
    public class ProjectOverviewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}