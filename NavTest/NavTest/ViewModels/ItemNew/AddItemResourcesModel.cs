using System;
namespace NavTest.ViewModels.ItemNew
{
    public struct AddItemResourcesModel
    {
        public string Title { get; }

        public string ItemTitle { get; }
        public Int32 ItemTitleColor { get; }

        public string ItemDescription { get; }
        public Int32 DescriptionColor { get; }

        internal AddItemResourcesModel(
            string title,
            string itemTitle,
            string itemDescription,
            Int32 titleColor,
            Int32 descriptionColor)
        {
            this.Title = title;
            this.ItemTitle = itemTitle;
            this.ItemDescription = itemDescription;
            this.ItemTitleColor = titleColor;
            this.DescriptionColor = descriptionColor;
        }
    }
}
