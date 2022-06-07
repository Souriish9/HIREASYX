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
    public class RegistrationModel : PageModel
    {
        CurdOps ob = new CurdOps();

        [BindProperty]
        public Register register { get; set; }

        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            bool result = ob.AddAdmin(register);

            if(result==true)
            {
                return RedirectToPage("./Login");
            }
            else
            {
                return RedirectToPage("./Error");
            }
        }
    }
}