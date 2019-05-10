﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodAndStyleOrderPlanning.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Claims { get; set; }

        public void OnGet()
        {
            //this.PageContext.HttpContext.Request

            Claims = new List<string>();

            Claims.Add(HttpContext.Request.Headers["X-MS-CLIENT-PRINCIPAL-NAME"].ToString());

            ClaimsPrincipal currentUser = this.User;

            if (currentUser == null)
                return;

            foreach(Claim c in currentUser.Claims)
            {
                Claims.Add($"{c.Type} - {c.Value}");
            }
        }
    }
}
