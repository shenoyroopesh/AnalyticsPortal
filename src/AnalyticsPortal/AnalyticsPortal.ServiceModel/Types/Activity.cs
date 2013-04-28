﻿using ServiceStack.DataAnnotations;

namespace AnalyticsPortal.ServiceModel.Types
{
    [Alias("analytics.activities")]
    public class Activity 
    {
        [Alias("activity_id"), PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Difficulty { get; set; }

        public string Logo { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Prerequisite { get; set; }

        public string Goal { get; set; }
    }
}
