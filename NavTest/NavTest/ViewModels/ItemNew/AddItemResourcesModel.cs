using System;
namespace NavTest.ViewModels.ItemNew
{
    public struct AddItemResourcesModel
    {
        public readonly string title;
        public readonly string itemTitle;
        public readonly string itemDescription;
        public readonly Int32 titleColor;
        public readonly Int32 descriptionColor;

        internal AddItemResourcesModel(
           string title,
        string itemTitle,
        string itemDescription,
        Int32 titleColor,
        Int32 descriptionColor) 
        {
            this.title = title;
            this.itemTitle = itemTitle;
            this.itemDescription = itemDescription;
            this.titleColor = titleColor;
            this.descriptionColor = descriptionColor;
        }
    }
}
