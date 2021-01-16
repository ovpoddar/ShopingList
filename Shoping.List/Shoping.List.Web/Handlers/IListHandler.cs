using Shoping.List.Web.Models;

namespace Shoping.List.Web.Handlers
{
    public interface IListHandler<T>
    {
        T AddItem(T items, string newItem);
        ResultModel<T> DeleteItem(T items, uint id);
    }
}
