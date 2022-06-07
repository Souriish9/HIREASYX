using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using hireasyX.Model;
using hireasyX.CURD;

namespace hireasyX.Pages.Admin
{
    public class PostAJobModel : PageModel
    {
        CurdOps ob = new CurdOps();

        [BindProperty]
        public Jobs jobs { get; set; }

        public void OnGet()
        {

        }


        public ActionResult OnPost()
        {
            bool result = ob.AddJob(jobs);

            if (result == true)
            {
                return RedirectToPage("/FJ");
            }
            else
            {
                return RedirectToPage("./Error");
            }
        }
    }
}