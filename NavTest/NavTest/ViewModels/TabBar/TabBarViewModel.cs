using System;

namespace NavTest.ViewModels.TabBar
{
    public class TabBarViewModel : BaseViewModel<TabBarResourcesModel>
    {
        public Action ItemsAction { get; internal set; }
        public Action AboutAction { get; internal set; }
        internal TabBarViewModel() : base()
        {

        }
    }
}
