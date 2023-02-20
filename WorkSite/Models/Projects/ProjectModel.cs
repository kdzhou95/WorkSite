﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkSite.Models.Projects
{
    public class ProjectModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Specifications { get; set;}

        public string Type { get; set; }

        public string Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? CompleteDate { get; set; }

        public string PreviewPath { get; set; }
    }
}