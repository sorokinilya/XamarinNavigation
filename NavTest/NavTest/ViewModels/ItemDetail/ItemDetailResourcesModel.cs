using System;
namespace NavTest.ViewModels.ItemDetail
{
    public struct ItemDetailResourcesModel
    {
        public string Title { get; }

        internal ItemDetailResourcesModel(string title)
        {
            this.Title = title;
        }
    }
}