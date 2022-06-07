using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;


namespace hireasyX.Model
{
   
    public class Person
    {
        [BindProperty]

        public string Firstname { get; set; }

        [BindProperty]

        public string Lastname { get; set; }

    }
}
