using System;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemNew
{
    internal class AddItemController : BaseController<AddItemViewModel>
    {
        internal AddItemController(BaseRouter router) : base(router)
        {
            ViewModel.AddItem = async (item) =>
            {
                await ServiceLayer.Instance.DataStore.AddItemAsync(item);
                router.ShowItems();
            };
        }
    }
}
