using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shoping.List.Web.Handlers;
using Shoping.List.Web.Models;
using Shoping.List.Web.VewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.List.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListHandler<List<ItemModel>> _list;

        public HomeController(IListHandler<List<ItemModel>> list)
        {
            _list = list ?? throw new ArgumentNullException(nameof(_list));
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = new HomeViewModel
            {
                Items = null,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            var add = _list.AddItem(model.Items, model.Name);
            var m = new HomeViewModel
            {
                Name = model.Name,
                Items = add
            };
            return View(m);
        }

        [HttpPost]
        public IActionResult Delete(int id, List<int> i, List<string> p)
        {
            var m = _list.Model(i, p);
            var rm = _list.DeleteItem(m, (uint)id);
            var retuenm = new HomeViewModel
            {
                Name = null,
                Items = rm
            };
            return View("Index", retuenm);
        }
    }
}
