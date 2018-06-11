using System;
using System.Collections.ObjectModel;

namespace NavTest.ViewModels.Items
{
    public class ItemsViewModel : BaseViewModel<ItemsResourcesModel>
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
        public Action ReloadItemsAction { get; set; }

    }
}
