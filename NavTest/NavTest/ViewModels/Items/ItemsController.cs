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

        internal ItemsController() : base(new ItemsViewModel())
        {
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            this.viewModel.Resources = new ItemsResourcesModel(resourcesService.GetString(Services.Resources.LocalizedKey.I_Title));
            base.viewModel.ReloadAction = () =>
            {
                this.LoadItems();
            };

            this.viewModel.NewItemAction = () =>
            {
                ServiceLayer.Instance.Router.ShowNewItem();
            };
            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released" + this.GetType());
                ServiceLayer.Instance.Router.ReleaseConroller(this.GetType());
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
                    var id = item.Id;
                    this.viewModel.Items.Add(new Item(item.Id, item.Text, item.Description, () =>
                    {
                        ServiceLayer.Instance.Router.ShowItemDetails(id);
                    }));
                }
            });
        }
    }
}
