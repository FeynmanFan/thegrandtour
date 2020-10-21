using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BehrensTech.DessertStore.Web.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var userName = this.UserName;
            var password = this.Password;
            var firstName = this.FirstName;
        }

        public bool Authenticate(string username, string password)
        {
            if (username == "cbehrens" && password == "RIPEVH")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

