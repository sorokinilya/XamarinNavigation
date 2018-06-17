using System;
namespace NavTest.ViewModels.ItemNew
{
    public class AddItemViewModel : BaseViewModel<AddItemResourcesModel>
    {
        public Action<Item> SaveItem { get; set; }

        internal AddItemViewModel() : base() { }
    }
}
