using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Dexterity.Login.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dexterity.Login.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var vm = new ProfileViewModel();
            vm.Claims = new Dictionary<string, string>();

            foreach(Claim claim in User.Claims)
            {
                vm.Claims.Add(claim.Type, claim.Value);
            }

            vm.AccessToken = await HttpContext.GetTokenAsync("access_token");
            vm.IdToken = await HttpContext.GetTokenAsync("id_token");

            return View(vm);
        }
    }
}