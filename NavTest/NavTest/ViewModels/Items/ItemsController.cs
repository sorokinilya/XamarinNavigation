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
            this.viewModel.Busy = true;
            Task.Run(async () =>
            {
                var items = await dataStore.GetItemsAsync();
                foreach (var item in items)
                {
                    this.viewModel.Items.Add(new Item(item.Id, item.Text, item.Description));
                }
                this.viewModel.Busy = false;
            });
        }
    }
}
