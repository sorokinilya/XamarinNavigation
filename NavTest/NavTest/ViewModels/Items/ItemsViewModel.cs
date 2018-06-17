using System;
using System.Collections.ObjectModel;

namespace NavTest.ViewModels.Items
{
    public class ItemsViewModel : BaseViewModel<ItemsResourcesModel>
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
        public Action ReloadAction { get; internal set; }
        public Action<int> SelectedAction { get; internal set; }
        public Action NewItemAction { get; internal set; }

        internal ItemsViewModel() : base() { }

    }
}
