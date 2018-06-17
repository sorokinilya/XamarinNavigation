using System;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.TabBar
{
    public class TabBarUIModel
    {
        public string BrowseTitle { get; internal set; }
        public string BrowseImage { get; internal set; }
        public string AboutTitle { get; internal set; }
        public string AboutImage { get; internal set; }


        internal TabBarUIModel() { }
    }
}
