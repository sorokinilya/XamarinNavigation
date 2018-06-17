using System;
using NavTest.Services.Resources;

namespace NavTest.ViewModels.TabBar
{
    public class TabBarUIModel
    {
        public string BrowseTitle { get; internal set; }
        public IImage BrowseImage { get; internal set; }
        public string AboutTitle { get; internal set; }
        public IImage AboutImage { get; internal set; }


        internal TabBarUIModel() { }
    }
}
