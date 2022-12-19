using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]

    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<RoleDto> roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
            }).ToList();
            return View(roles);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleDto roleDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new Role
                {
                    Name = roleDto.Name,
                    Description = roleDto.Description,
                });
                if (result.Succeeded)
                {
                    TempData["Message"] = Jobs.CreateMessage("Başarılı", roleDto.Name + " rolü, başarıyla eklenmiştir.", "success");
                    return RedirectToAction("Index", "Role");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }


            }
            return View();
        }

        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id); // id üzerinde rol bilgilerine erişeceğiz.
            if (role == null)
            {
                return NotFound();
            }
            var users = _userManager.Users;// Bütün kullancııları rolleri farketmeksizin users değişkenine attık
            var members = new List<User>();// İlgili role ait kullanıcılar
            var nonMembers = new List<User>();//İlgili role ait olmayan kullanıcılar
            foreach (var user in users)
            {
                #region Uzun yol 
                //var isInRole=await _userManager.IsInRoleAsync(user,role.Name);// Kullanıcı bu rolde mi değil mi  ? Bool olarak geri döndürür.
                //if (isInRole==true)
                //{
                //    members.Add(user);// eğer o roldeyse members listesine ekle
                //}
                //else
                //{
                //    nonMembers.Add(user);//Eğer o rolde değilse nonMembers listesine ekle.
                //}
                #endregion

                #region Kısa yol
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
                #endregion
            }
            RoleDetailsDto roleDetailsDto = new RoleDetailsDto
            {
                Role = role,
               Members= members,
               NonMembers=nonMembers
            };
            return View(roleDetailsDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleEditDto roleEditDto)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in roleEditDto.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user==null) { return NotFound(); }

                    var result = await _userManager.AddToRoleAsync(user, roleEditDto.RoleName);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                foreach (var userId in roleEditDto.IdsToRemove ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user == null) { return NotFound(); }

                    var result = await _userManager.RemoveFromRoleAsync(user, roleEditDto.RoleName);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                
            }
            return Redirect("/Admin/Role/Edit/" + roleEditDto.RoleId);
        }
    }
}
