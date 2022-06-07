using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using hireasyX.Model;
using hireasyX.CURD;

namespace hireasyX.Pages
{
    public class FJModel : PageModel
    {
        [BindProperty]
        public List<Jobs> jobs { get; set; }

        public void OnGet()
        {
            jobs = CurdOps.getJobData().ToList();
        }
    }
}