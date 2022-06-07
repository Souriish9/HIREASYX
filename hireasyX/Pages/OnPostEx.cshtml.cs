using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using hireasyX.Model;

namespace hireasyX.Pages
{
    public class OnPostExModel : PageModel
    {
        public void OnGet()
        {

        }

        
        public string MyData { get; set; }

       


        public void OnPostSubmit(Person obj)
        {
            this.MyData = obj.Firstname + obj.Lastname;
        }

        public string Test { get; set; }
        public void OnPostHello()
        {
            Test = "hellllow!";
        }
    }
}