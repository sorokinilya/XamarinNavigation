using System;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemNew
{
    public class AddItemController : BaseController<AddItemViewModel>
    {
        public AddItemController(IRouter router) : base(router)
        {
            ViewModel.AddItem = async (item) =>
            {
                await ServiceLayer.Instance.DataStore.AddItemAsync(item);
                router.ShowItems();
            };
        }
    }
}
