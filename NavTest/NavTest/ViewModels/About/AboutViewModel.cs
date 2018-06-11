using System;

namespace NavTest.ViewModels.About
{
    public class AboutViewModel : BaseViewModel<AboutResourcesModel>
    {
        public Action ShowWebPage { get; set; }
    }
}