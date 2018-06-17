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

        internal AddItemController(BaseRouter router) : base(new AddItemViewModel())
        {
            var resourcesService = ServiceLayer.Instance.ResourcesService;
            base.viewModel.resources.TitleColor = resourcesService.GetColor(ColorKey.Main);
            base.viewModel.resources.DescriptionColor = resourcesService.GetColor(ColorKey.Tint);
            base.viewModel.resources.Title = resourcesService.GetString(LocalizedKey.AI_Title);
            base.viewModel.resources.ItemTitle = resourcesService.GetString(LocalizedKey.AI_ItemTitle);
            base.viewModel.resources.ItemDescription = resourcesService.GetString(LocalizedKey.AI_ItemDescription);

            base.viewModel.SaveItem = async (item) =>
            {
                var storeItem = new Services.Store.Item()
                {
                    Description = item.description,
                    Text = item.text,
                    Id = 0
                };
                await dataStore.AddItemAsync(storeItem);
                router.ShowItems();
            };

            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released " + this.GetType());
                router.ReleaseConroller(this.GetType());
            };
        }
    }
}
