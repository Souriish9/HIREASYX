using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hireasyX.Model
{
    public class Jobs
    {
        [BindProperty]
        public string HE_JOBID { get; set; }

        [BindProperty]
        public string USERID { get; set; }


        [BindProperty]
        public string JOB_TITLE { get; set; }

        [BindProperty]
        public string COMPANY_NAME { get; set; }

        [BindProperty]
        public string LOCATION { get; set; }

        [BindProperty]
        public string JOB_NATURE { get; set; }

        [BindProperty]
        public string COMAPNY_WEBSITE { get; set; }

        [BindProperty]
        public string COMAPNY_EMAIL { get; set; }

        [BindProperty]
        public string JOB_CATEGORY { get; set; }

        [BindProperty]
        public string JOB_DESC { get; set; }

        [BindProperty]
        public string SALARY { get; set; }

        [BindProperty]
        public string APPLY_LINK { get; set; }
    }
}
