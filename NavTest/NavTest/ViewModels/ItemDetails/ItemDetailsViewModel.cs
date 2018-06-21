using System;

namespace NavTest.ViewModels.ItemDetail
{
    public class ItemDetailsViewModel : BaseViewModel<ItemDetailsResourcesModel>
    {
        public Item Item { get; set; }

        internal ItemDetailsViewModel() : base()
        {
        }
    }
}
