﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AddressBookWeb.Controllers
{
    public class AppRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // List All the Roles created bu User
		public IActionResult Index()
		{
            var roles = _roleManager.Roles;
			return View(roles);
		}

        [HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]

        public async Task<IActionResult> Create(IdentityRole model)
        {
            // avoide publicate role
            if(!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }

            return RedirectToAction("Index");
        }
    }
}
