using System;
using System.Collections.Specialized;
using NavTest.iOS.ViewControllers;
using NavTest.iOS.ViewControllers.Browse;
using NavTest.ViewModels.Items;
using UIKit;

namespace NavTest.iOS
{
    public partial class BrowseViewController : BaseViewController<ItemsViewModel>
    {
        UIRefreshControl refreshControl;

        internal BrowseViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Setup UITableView.
            this.refreshControl = new UIRefreshControl();
            this.refreshControl.ValueChanged += RefreshControl_ValueChanged;
            this.tableView.Add(refreshControl);
            this.tableView.Source = new ItemsDataSource(ViewModel.Items, ViewModel.SelectedAction);
            this.btnAddItem.TouchUpInside += (sender, ea) => ViewModel.NewItemAction();
            this.ViewModel.Items.CollectionChanged += this.OnCollectionChanged;
            Title = ViewModel.resources.Title;
        }


        void RefreshControl_ValueChanged(object sender, EventArgs e)
        {
            this.ViewModel.ReloadAction();
        }

        //    void IsBusy_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //    {
        //        var propertyName = e.PropertyName;
        //        switch (propertyName)
        //        {
        //            case nameof(ViewModel.IsBusy):
        //                {
        //                    InvokeOnMainThread(() =>
        //                    {
        //                        if (ViewModel.IsBusy && !refreshControl.Refreshing)
        //                            refreshControl.BeginRefreshing();
        //                        else if (!ViewModel.IsBusy)
        //                            refreshControl.EndRefreshing();
        //                    });
        //                }
        //                break;
        //        }
        //    }

        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            InvokeOnMainThread(() => tableView.ReloadData());
        }
        //}

    }
}
