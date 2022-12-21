using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

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
            ViewBag.SelectedMenu = "Role";
            ViewBag.Title = "Roller";
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
            return View(roleDto);
        }
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            var users = _userManager.Users; //Bütün user'ları almaya yarıyor.
            var members = new List<User>(); //İlgili role ait OLAN kullanıcılar için bir liste.
            var nonMembers = new List<User>(); //İlgili role ait OLMAYAN kullanıcılar için bir liste.
            foreach (var user in users)
            {
                #region UzunYol
                //var isInRole = await _userManager.IsInRoleAsync(user, role.Name); //user'ın rolden olup olup olmadığını true or false olarak döndüren method: IsInRoleAsync
                //if (isInRole)
                //{
                //    members.Add(user);
                //}
                //else
                //{
                //    nonMembers.Add(user);
                //}
                #endregion
                #region KısaYol
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers; //eğer rolün üyesi ise members'a aktar değilse nonMembers'a aktar.
                list.Add(user);
                #endregion
            }
            var roleDetailsDto = new RoleDetailsDto
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(roleDetailsDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleEditDetailsDto roleEditDetailsDto)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in roleEditDetailsDto.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user == null)
                    {
                        return NotFound();
                    }
                    var result = await _userManager.AddToRoleAsync(user, roleEditDetailsDto.RoleName); //Sıradaki user'ı roleEditDetailsDto modelinden gelen role'e ekle.
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                foreach (var userId in roleEditDetailsDto.IdsToRemove ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user == null)
                    {
                        return NotFound();
                    }
                    var result = await _userManager.RemoveFromRoleAsync(user, roleEditDetailsDto.RoleName); //Sıradaki user'ı roleEditDetailsDto modelinden gelen role'e ekle.
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
            }

            return Redirect("/Admin/Role/Edit/" + roleEditDetailsDto.RoleId); //Redirect ile içerisine direkt olarak link vererek yönlendirme yapabiliyoruz.
        }


        public IActionResult UserRoles()
        {
            var users = _userManager.Users.Select(u => new User //Bütün user bilgilerini çekmemek için her bir user için yeni bir user oluşturup kendi istediğimiz bilgilerini(Id, FirstName, LastName, UserName) çekmek için bu şekilde yaptık.
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName
            }).ToList();
            var roles = _roleManager.Roles.Select(r => new Role
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToList();
            List<SelectListItem> selectRoleList = roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();
            UserRolesDto userRolesDto = new UserRolesDto
            {
                SelectRoleList = selectRoleList,
                Users = users
            };
            ViewBag.SelectedMenu = "UserRoles";
            ViewBag.Title = "Rol Atama";
            return View(userRolesDto);
        }


        public async Task<IActionResult> GetUsers(UserRolesDto userRolesDto)
        {
            var role = await _roleManager.FindByIdAsync(userRolesDto.RoleId);
            var members = new List<User>();
            var nonMembers = new List<User>();
            var users = _userManager.Users.Select(u => new User
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName
            }).ToList();
            foreach (var user in users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers; 
                list.Add(user);
            }
            var roleDetailsDto = new RoleDetailsDto
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            var roles = _roleManager.Roles.Select(r => new Role
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToList();
            List<SelectListItem> selectRoleList = roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();
            userRolesDto.SelectRoleList = selectRoleList;
            userRolesDto.RoleDetailsDto= roleDetailsDto;
            userRolesDto.Users = users;
            return View("UserRoles",userRolesDto);
        }
    }
}
