using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsWebApp_MVC5_.Models.ViewModel
{
    public class NewJobsViewModel
    {
        public IEnumerable<JobsCategory> JobsCategory { get; set; }
        public Jobs Jobs { get; set; }
    }
}