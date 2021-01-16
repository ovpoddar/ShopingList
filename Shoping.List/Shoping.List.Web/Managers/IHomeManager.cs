using Shoping.List.Web.VewModels;

namespace Shoping.List.Web.Managers
{
    public interface IHomeManager<T>
    {
        T CreateGetRequest { get; }

        T CreatePostRequest(T model);
        T RemovePostRequest(RemoveViewModel model);
    }
}
