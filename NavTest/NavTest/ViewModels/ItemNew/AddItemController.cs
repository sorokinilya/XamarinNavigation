using NavTest.Services;
using NavTest.Services.Store;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemNew
{
    internal class AddItemController : BaseController<AddItemViewModel>
    {

        private DataStore dataStore = ServiceLayer.Instance.DataStore;

        internal AddItemController(BaseRouter router) : base(router, new AddItemViewModel())
        {

            base.ViewModel.AddItem = async (item) =>
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
        }
    }
}
