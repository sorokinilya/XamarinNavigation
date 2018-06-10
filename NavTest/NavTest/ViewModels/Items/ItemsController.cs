using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.Items
{
    public class ItemsController : BaseController<ItemsViewModel>
    {

       // private DataStore DataStore { get; set; } = ServiceLayer.Instance.DataStore;

        public ItemsController(IRouter router) : base(router)
        {

        }
    }
}
