using Shoping.List.Web.Models;
using System.Collections.Generic;

namespace Shoping.List.Web.VewModels
{
    public class CreateViewModel
        {
            public List<ItemModel> Items { get; set; }
            public string Name { get; set; }
        }
}
