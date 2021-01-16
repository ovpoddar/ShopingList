using Shoping.List.Web.Handlers;
using Shoping.List.Web.Models;
using Shoping.List.Web.VewModels;
using System;
using System.Collections.Generic;

namespace Shoping.List.Web.Managers
{
    public class HomeManager : IHomeManager<CreateViewModel>
    {
        private readonly IListHandler<List<ItemModel>> _handler;

        public HomeManager(IListHandler<List<ItemModel>> handler)
        {
            _handler = handler ?? throw new ArgumentNullException(nameof(_handler));
        }

        public CreateViewModel CreateGetRequest =>
            new CreateViewModel
            {
                Items = new List<ItemModel>()
            };

        public CreateViewModel CreatePostRequest(CreateViewModel model)
        {
            return new CreateViewModel()
            {
                Name = model.Name,
                Items = _handler.AddItem(model.Items, model.Name)
            };
        }

        public CreateViewModel RemovePostRequest(RemoveViewModel model)
        {
            var result = _handler.DeleteItem(model.Items, (uint)model.Id);
            return new CreateViewModel
            {
                Items = result.Result,
                ErrMessage = result.ErrMessage
            };
        }
    }
}
