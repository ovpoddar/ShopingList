using Shoping.List.Web.Models;
using System.Collections.Generic;

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

        public ResultModel<List<ItemModel>> DeleteItem(List<ItemModel> items, uint id)
        {
            var success = items.Remove(items.Find(e => e.ItemId == id));
            if (success)
                return new ResultModel<List<ItemModel>>()
                {
                    ErrMessage = "No Err Found",
                    Result = items
                };
            return new ResultModel<List<ItemModel>>()
            {
                Result = items,
                ErrMessage = "the product is not exist anymore"
            };
        }
    }
}

