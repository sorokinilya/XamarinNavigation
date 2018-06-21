using System.Diagnostics;
using NavTest.Services;
using NavTest.Services.Resources;
using NavTest.Services.Store;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemNew
{
    internal class AddItemController : BaseController<AddItemViewModel>
    {

        private DataStore dataStore = ServiceLayer.Instance.DataStore;

        internal AddItemController() : base(new AddItemViewModel())
        {
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            this.viewModel.Resources = new AddItemResourcesModel(
                resourcesService.GetString(LocalizedKey.AI_Title),
                resourcesService.GetString(LocalizedKey.AI_ItemTitle),
                resourcesService.GetString(LocalizedKey.AI_ItemDescription),
                resourcesService.GetColor(ColorKey.Main),
                resourcesService.GetColor(ColorKey.Tint)
            );

            base.viewModel.SaveItem = async (item) =>
            {
                var storeItem = new Services.Store.Item()
                {
                    Description = item.description,
                    Text = item.text,
                    Id = 0
                };
                await dataStore.AddItemAsync(storeItem);
                ServiceLayer.Instance.Router.ShowItems();
            };

            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released " + this.GetType());
                ServiceLayer.Instance.Router.ReleaseConroller(this.GetType());
            };
        }
    }
}
