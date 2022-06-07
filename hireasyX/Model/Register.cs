using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hireasyX.Model
{
    public class Register
    {
        [BindProperty]
        public string NAME { get; set; }

        [BindProperty]
        public string EMAILID { get; set; }

        [BindProperty]
        public string PASSWORD { get; set; }

        [BindProperty]
        public string DEPARTMENT { get; set; }
    }
}
