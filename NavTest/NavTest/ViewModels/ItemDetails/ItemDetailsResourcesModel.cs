using System;
namespace NavTest.ViewModels.ItemDetail
{
    public struct ItemDetailsResourcesModel
    {
        public string Title { get; }

        internal ItemDetailsResourcesModel(string title)
        {
            this.Title = title;
        }
    }
}