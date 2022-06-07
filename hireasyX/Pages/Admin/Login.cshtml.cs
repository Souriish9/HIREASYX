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
    public class loginModel : PageModel
    {
        [BindProperty]
        public Register register { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            bool res = CurdOps.Login(register);
            if (res == true)
            {
                return RedirectToPage("PostAJob");
            }
            else
            {
                return RedirectToPage("./Error");
            }
        }
    }
}