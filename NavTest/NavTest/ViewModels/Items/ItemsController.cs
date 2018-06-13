using System.Threading.Tasks;
using NavTest.Services;
using NavTest.Services.Store;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.Items
{
    internal class ItemsController : BaseController<ItemsViewModel>
    {

        private DataStore dataStore = ServiceLayer.Instance.DataStore;

        internal ItemsController(BaseRouter router) : base(router, new ItemsViewModel())
        {
            Task.Run(async () =>
            {
                var items = await dataStore.GetItemsAsync();
                foreach (var item in items)
                {
                    this.viewModel.Items.Add(new Item(item.Id, item.Text, item.Description));
                }
            });

            base.viewModel.ReloadItemsAction = () =>
            {
            };
        }
    }
}
