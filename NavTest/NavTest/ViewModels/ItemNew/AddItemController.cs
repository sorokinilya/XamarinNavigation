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
            base.viewModel.resources.TitleColor = base.resourcesService.GetColor(Color.Main);
            base.viewModel.resources.DescriptionColor = base.resourcesService.GetColor(Color.Tint);
            base.viewModel.resources.Title = base.resourcesService.GetString(Localized.AI_Title);
            base.viewModel.resources.ItemTitle = base.resourcesService.GetString(Localized.AI_ItemTitle);
            base.viewModel.resources.ItemDescription = base.resourcesService.GetString(Localized.AI_ItemDescription);

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
