using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NavTest.Services;
using NavTest.Services.Store;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemDetail
{
    internal class ItemDetailsController : BaseController<ItemDetailsViewModel>
    {
        private int id = 0;
        private DataStore dataStore = ServiceLayer.Instance.DataStore;

        internal int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    this.LoadItem();
                }
            }
        }

        internal ItemDetailsController() : base(new ItemDetailsViewModel())
        {
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            this.viewModel.Resources = new ItemDetailsResourcesModel(resourcesService.GetString(Services.Resources.LocalizedKey.ID_Title));
            this.viewModel.Item = new Item("", "");

            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released" + this.GetType());
                ServiceLayer.Instance.Router.ReleaseConroller(this.GetType());
            };
        }

        private void LoadItem()
        {
            Task.Run(async () =>
            {
                var item = await this.dataStore.GetItemAsync(this.Id);
                this.viewModel.Item = new Item(item.Text, item.Description);
            });
        }
    }
}
