using Shoping.List.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.List.Web.Handlers
{
    public class ListHandler : IListHandler<List<ItemModel>>
    {
        public List<ItemModel> AddItem(List<ItemModel> items, string newItem)
        {
            if (items == null)
                items = new List<ItemModel>();

            items.Add(new ItemModel
            {
                ItemId = (uint)items.Count,
                ItemDescription = newItem
            });
            return items;
        }

        public List<ItemModel> DeleteItem(List<ItemModel> items, uint id)
        {
            items.Remove(items.Find(e => e.ItemId == id));
            return items;
        }


        public List<ItemModel> Model(List<int> id, List<string> poduct)
        {
            if (id.Count == poduct.Count)
            {
                var model = new List<ItemModel>();
                for (var i = 0; i < id.Count; i++)
                {
                    var m = new ItemModel
                    {
                        ItemId = (uint)id[i],
                        ItemDescription = poduct[i]
                    };
                    model.Add(m);
                }
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}

