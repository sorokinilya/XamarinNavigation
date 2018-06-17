using System.Diagnostics;
using System.Threading.Tasks;
using NavTest.Services;
using NavTest.Services.Store;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.Items
{
    internal class ItemsController : BaseController<ItemsViewModel>
    {

        private DataStore dataStore = ServiceLayer.Instance.DataStore;

        internal ItemsController(BaseRouter router) : base(new ItemsViewModel())
        {
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            this.viewModel.Resources = new ItemsResourcesModel(resourcesService.GetString(Services.Resources.LocalizedKey.I_Title));
            base.viewModel.ReloadAction = () =>
            {
                this.LoadItems();
            };

            base.viewModel.SelectedAction = (id) =>
            {
                router.ShowItemDetail(id);
            };
            this.viewModel.NewItemAction = () =>
            {
                router.ShowNewItem();
            };
            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released" + this.GetType());
                router.ReleaseConroller(this.GetType());
            };
            this.LoadItems();
        }

        private void LoadItems()
        {
            Task.Run(async () =>
            {
                var items = await dataStore.GetItemsAsync();
                foreach (var item in items)
                {
                    this.viewModel.Items.Add(new Item(item.Id, item.Text, item.Description));
                }
            });
        }
    }
}
