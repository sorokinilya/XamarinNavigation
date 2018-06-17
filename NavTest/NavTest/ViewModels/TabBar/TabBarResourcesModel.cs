using System;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.TabBar
{
    public struct TabBarResourcesModel
    {
        public readonly string itemsTitle;
        public readonly string itemsImage;
        public readonly string itemsSelectedImage;

        public readonly string aboutTitle;
        public readonly string aboutImage;
        public readonly string aboutSelectedImage;

        public readonly Int32 textColor;
        public readonly Int32 selectedTextColor;

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
            this.itemsTitle = itemsTitle;
            this.itemsImage = itemsImage;
            this.itemsSelectedImage = itemsSelectedImage;

            this.aboutTitle = aboutTitle;
            this.aboutImage = aboutImage;
            this.aboutSelectedImage = aboutSelectedImage;

            this.textColor = textColor;
            this.selectedTextColor = selectedTextColor;
        }
    }
}
