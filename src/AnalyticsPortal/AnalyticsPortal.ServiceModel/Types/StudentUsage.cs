﻿using System;

namespace AnalyticsPortal.ServiceModel.Types
{
    public class StudentUsage
    {
        public DateTime LastPlayedDate { get; set; }

        public int LogCount { get; set; }

        public string Login { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}