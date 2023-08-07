﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testflow
{
    public class AppSettings
    {
        public String ArchiveDbConnectionString { get; set; }
        public String ArchiveTable { get; set; }

        public String LatestDbConnectionString { get; set; }
        public String LatestTable { get; set; }

        public String TargetDbConnectionString { get; set; }
        public String TargetTable { get; set; }
    }
}
