using Microsoft.AspNetCore.Mvc;
using Shoping.List.Web.Managers;
using Shoping.List.Web.VewModels;
using System;

namespace Shoping.List.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeManager<CreateViewModel> _manager;

        public HomeController(IHomeManager<CreateViewModel> manager)
        {
            _manager = manager ?? throw new ArgumentNullException(nameof(_manager));
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _manager.CreateGetRequest();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(CreateViewModel model)
        {
            var result = _manager.CreatePostRequest(model);
            return View(result);
        }

        [HttpPost]
        public IActionResult Delete(RemoveViewModel model)
        {
            var result = _manager.RemovePostRequest(model);
            return View("Index", result);
        }
    }
}
