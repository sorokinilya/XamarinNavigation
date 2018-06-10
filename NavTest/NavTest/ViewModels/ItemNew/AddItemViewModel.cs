using System;
namespace NavTest.ViewModels.ItemNew
{
    public class AddItemViewModel : BaseViewModel<AddItemUIModel>
    {
        public Action<Item> AddItem { get; set; }
    }
}
