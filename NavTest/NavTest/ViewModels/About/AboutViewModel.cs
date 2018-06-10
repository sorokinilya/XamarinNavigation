using System;

namespace NavTest.ViewModels.About
{
    public class AboutViewModel : BaseViewModel<AboutUIModel>
    {
        public Action ShowWebPage { get; set; }
    }
}