using Shoping.List.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.List.Web.VewModels
{
        public class HomeViewModel
        {
            public List<ItemModel> Items { get; set; }
            public string Name { get; set; }
        }
}
