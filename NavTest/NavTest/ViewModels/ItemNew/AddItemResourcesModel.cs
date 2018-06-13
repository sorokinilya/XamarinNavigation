using System;
namespace NavTest.ViewModels.ItemNew
{
    public class AddItemResourcesModel
    {
        public string Title { get; internal set; }

        public string ItemTitle { get; internal set; }

        public string ItemDescription { get; internal set; }

        public Int32 TitleColor { get; internal set; }

        public Int32 DescriptionColor { get; internal set; }

        internal AddItemResourcesModel() { }
    }
}
