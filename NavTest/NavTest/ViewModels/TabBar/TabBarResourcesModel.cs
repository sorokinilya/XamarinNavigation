using System;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.TabBar
{
    public struct TabBarResourcesModel
    {
        public string ItemsTitle { get; }
        public string ItemsImage { get; }
        public string ItemsSelectedImage { get; }

        public string AboutTitle { get; }
        public string AboutImage { get; }
        public string AboutSelectedImage { get; }

        public Int32 TextColor { get; }
        public Int32 SelectedTextColor { get; }

        internal TabBarResourcesModel(
            string itemsTitle,
            string itemsImage,
            string itemsSelectedImage,

            string aboutTitle,
            string aboutImage,
            string aboutSelectedImage,

            Int32 textColor,
            Int32 selectedTextColor)
        {
            this.ItemsTitle = itemsTitle;
            this.ItemsImage = itemsImage;
            this.ItemsSelectedImage = itemsSelectedImage;

            this.AboutTitle = aboutTitle;
            this.AboutImage = aboutImage;
            this.AboutSelectedImage = aboutSelectedImage;

            this.TextColor = textColor;
            this.SelectedTextColor = selectedTextColor;
        }
    }
}
