using Shoping.List.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.List.Web.Handlers
{
    public interface IListHandler<T>
    {
        T AddItem(T items, string newItem);
        T DeleteItem(T items, uint id);
        T Model(List<int> id, List<string> poduct);
    }
}
