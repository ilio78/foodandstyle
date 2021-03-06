﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAndStyleOrderPlanning.Core;
using FoodAndStyleOrderPlanning.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodAndStyleOrderPlanning.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly IData<User> data;

        [BindProperty]
        public new User User { get; set; }

        public EditModel(IData<User> data)
        {
            this.data = data;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
                User = new User();
            else
                User = data.GetById(id.Value);

            if (User == null)
                return RedirectToPage("./NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            if (User.Id > 0)
                data.Update(User);
            else
                data.Add(User);

            data.Commit();
            return RedirectToPage("./List");
        }
    }
}