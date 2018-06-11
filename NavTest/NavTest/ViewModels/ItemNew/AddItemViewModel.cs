using System;
namespace NavTest.ViewModels.ItemNew
{
    public class AddItemViewModel : BaseViewModel<AddItemResourcesModel>
    {
        public Action<Item> AddItem { get; set; }
    }
}
