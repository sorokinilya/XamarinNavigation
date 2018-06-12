using System;
using UIKit;

namespace NavTest.iOS.ViewControllers.TabBarController
{
    public class TabBarViewModel : BaseViewModel<TabBarUIModel>
    {
        internal TabBarViewModel() : base(new TabBarUIModel()) { }
    }
}
