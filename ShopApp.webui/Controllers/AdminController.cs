using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopApp.business.Abstract;
using shopApp.business.Concrete;
using shopApp.entity;
using ShopApp.webui.Extensions;
using ShopApp.webui.Identity;
using ShopApp.webui.Models;
using ShopApp.webui.ViewModels;

namespace ShopApp.webui.Controllers
{
    [Authorize(Roles = "admin")]

    public class AdminController : Controller
    {
        private IProductService _service;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _role;
        private UserManager<User> _user;
        public AdminController(IProductService service, ICategoryService categoryService, RoleManager<IdentityRole> role, UserManager<User> user)
        {
            _service = service;
            _categoryService = categoryService;
            _role = role;
            _user = user;
        }
        public async Task<IActionResult> ProductList()
        {
            return View(new ProductListViewModel()
            {
                product =await _service.GetAll()
            });
        }
        public IActionResult ProductCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(ProductModel product)
        {

            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = product.Name,
                    Description = product.Description,
                    ImageUrl = product.ImageUrl,
                    ProductUrl = product.ProductUrl,
                    Price = product.Price
                };
                if (_service.Create(entity))
                {
                    TempData.Put("message", new AlertMessage() { Title = "Product", Message = "Product is created", AlertType = "success" });

                    return RedirectToAction("ProductList");
                }
                else
                {
                    TempData.Put("message", new AlertMessage() { Title = "Product", Message = "Something went wrong", AlertType = "danger" });

                    return View(product);
                }


            }

            return View(product);
        }
        public async Task<IActionResult> ProductEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _service.GetByIdWithCategories((int)id);
            if (entity == null) { return NotFound(); }
            var model = new ProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                ProductUrl = entity.ProductUrl,
                ImageUrl = entity.ImageUrl,
                Description = entity.Description,
                Price = entity.Price,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                category = entity.ProductCategories.Select(i => i.Category).ToList()
            };
            ViewBag.Categories =await _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ProductEdit(ProductModel product, int[] CategoryId, IFormFile file)
        {
            Console.WriteLine("burdaydın");

            if (ModelState.IsValid)
            {
                var entity = _service.GetByIdWithCategories(product.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                
                entity.Name = product.Name;
                entity.Description = product.Description;
                entity.Price = product.Price;
                entity.ProductUrl = product.ProductUrl;
                // entity.ImageUrl = product.ImageUrl;
                entity.IsHome = product.IsHome;
                entity.IsApproved = product.IsApproved;
                if (file != null)
                {
                    // entity.ImageUrl = file.FileName;
                    var ext = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{ext}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                if (_service.Update(entity, CategoryId))
                {
                    TempData.Put("message", new AlertMessage() { Title = "Product", Message = "Product is updated", AlertType = "success" });
                    return RedirectToAction("ProductList");
                }
                else
                {
                    ViewBag.Categories =await  _categoryService.GetAll();
                    TempData.Put("message", new AlertMessage() { Title = "Product", Message = "Product is updated", AlertType = "success" });

                    return View(product);
                }

            }

            ViewBag.Categories = await _categoryService.GetAll();
            return View(product);

        }
        public async Task<IActionResult> deleteProduct(int? id)
        {
            var entity =await _service.GetById((int)id);
            if (entity != null)
            {
                _service.Delete(entity);
            }
            var msg = new AlertMessage()
            {
                Message = $"{entity.Name} deleted",
                AlertType = "danger"
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> CategoryList()
        {
            return View(new CategoryListViewModel()
            {
                Categories = await _categoryService.GetAll()
            });
        }
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = category.Name,
                    Url = category.Url
                };

                _categoryService.Create(entity);
                TempData.Put("message", new AlertMessage() { Title = "Category", Message = "Category is created", AlertType = "success" });

                return RedirectToAction("CategoryList");
            }
            return View(category);
        }


        public IActionResult CategorydEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetByIdWithProducts((int)id);
            if (entity == null) { return NotFound(); }
            var model = new CategoryModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
                Products = entity.ProductCategories.Select(p => p.Product).ToList()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult CategorydEdit(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = _categoryService.GetByIdWithProducts(category.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Name = category.Name;
                entity.Url = category.Url;
                _categoryService.Update(entity);
                TempData.Put("message", new AlertMessage() { Title = "Category", Message = "Category is updated", AlertType = "warning" });

                return RedirectToAction("CategoryList");

            }
            return View(category);
        }
        public async Task<IActionResult> deleteCategory(int? id)
        {
            var entity = await _categoryService.GetById((int)id);
            if (entity != null)
            {
                _categoryService.Delete(entity);
            }
            TempData.Put("message", new AlertMessage() { Title = "Category", Message = "Category is deleted", AlertType = "success" });

            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult deleteFromCategory(int Id, int categoryId)
        {
            _categoryService.deleteFromCategory(Id, categoryId);

            return Redirect("/admin/categories/" + categoryId);
        }
        // public void CreateMessage(string message, string alertType)
        // {
        //     var msg = new AlertMessage()
        //     {
        //         Message = message,
        //         AlertType = alertType
        //     };
        //     TempData["message"] = JsonConvert.SerializeObject(msg);

        // }

        public IActionResult RoleList()
        {
            return View(_role.Roles);
        }
        public async Task<IActionResult> RoleEdit(string Id)
        {
            var role = await _role.FindByIdAsync(Id);
            var members = new List<User>();
            var nonMembers = new List<User>();
            foreach (var user in _user.Users)
            {
                var list = await _user.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _user.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _user.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }
                }
                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _user.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _user.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/admin/role/" + model.RoleId);

        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RoleCreate(RoleModel role)
        {
            if (ModelState.IsValid)
            {
                var result = await _role.CreateAsync(new IdentityRole(role.RoleName));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("Error", error.Description);
                    }
                }
            }
            return View(role);
        }

        public IActionResult UserList()
        {

            return View(_user.Users);
        }
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _user.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _user.GetRolesAsync(user);
                var roles = _role.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/Admin/user/list");

        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {

            if (ModelState.IsValid)
            {
                Console.WriteLine("aa");
                Console.WriteLine(model.UserId);
                Console.WriteLine("model.Email");
                var user = await _user.FindByIdAsync(model.UserId);
                Console.WriteLine(model.UserId);
                if (user != null)
                {

                    Console.WriteLine("aaaa");
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.Username;
                    user.EmailConfirmed = model.EmailConfirmed;
                    user.Email = model.Email;
                    var result = await _user.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var roles = await _user.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _user.AddToRolesAsync(user, selectedRoles.Except(roles).ToArray<string>());
                        await _user.RemoveFromRolesAsync(user, roles.Except(selectedRoles).ToArray<string>());
                        return Redirect("/admin/user/list");

                    }
                }
                return View(model);

            }
            return View();
        }
    }
}