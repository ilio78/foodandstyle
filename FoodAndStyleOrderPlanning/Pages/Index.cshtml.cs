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
        public string UPN { get; set; }

        public void OnGet()
        {
            UPN = HttpContext.Request.Headers["X-MS-CLIENT-PRINCIPAL-NAME"];   
        }
    }
}
