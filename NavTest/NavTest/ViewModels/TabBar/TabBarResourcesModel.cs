using System;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.TabBar
{
    public class TabBarResourcesModel
    {
        public string ItemsTitle { get; internal set; }
        public string ItemsImage { get; internal set; }
        public string ItemsSelectedImage { get; internal set; }

        public string AboutTitle { get; internal set; }
        public string AboutImage { get; internal set; }
        public string AboutSelectedImage { get; internal set; }

        public Int32 TextColor { get; internal set; }
        public Int32 SelectedTextColor { get; internal set; }

        internal TabBarResourcesModel() { }
    }
}
