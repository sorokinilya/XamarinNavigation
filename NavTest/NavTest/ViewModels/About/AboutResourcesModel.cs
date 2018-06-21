using System;
namespace NavTest.ViewModels.About
{
    public struct AboutResourcesModel
    {
        public string Title { get; }

        internal AboutResourcesModel(string title)
        {
            this.Title = title;
        }
    }
}
