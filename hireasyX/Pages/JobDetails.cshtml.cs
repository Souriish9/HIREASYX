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
    public class JobDetailsModel : PageModel
    {
        [BindProperty]
        public Jobs jobs { get; set; }

        public ActionResult OnGet(int heid)
        {
            if (heid.ToString() == null)
            {
                return NotFound();
            }
            else
            {
                jobs = CurdOps.GetDataByID(heid);
            }
            return Page();
        }
    }
}