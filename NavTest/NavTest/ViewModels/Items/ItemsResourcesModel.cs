using System;
namespace NavTest.ViewModels.Items
{
    public struct ItemsResourcesModel
    {
        public string Title { get; }

        internal ItemsResourcesModel(string title)
        {
            this.Title = title;
        }
    }
}
