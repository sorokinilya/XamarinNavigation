using System;
using System.Collections.Specialized;

using Foundation;
using NavTest.iOS.ViewControllers;
using NavTest.ViewModels.Items;
using UIKit;

namespace NavTest.iOS
{
    public class BrowseViewController : BaseViewController<ItemsViewModel>, UITableViewDelegate, UITableViewDataSource
    {

        static readonly NSString CELL_IDENTIFIER = new NSString("ITEM_CELL");
        //    UIRefreshControl refreshControl;

        //    public ItemsViewModel ViewModel { get; set; }


        internal BrowseViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            // Setup UITableView.
            //refreshControl = new UIRefreshControl();
            //refreshControl.ValueChanged += RefreshControl_ValueChanged;
            //TableView.Add(refreshControl);
            //TableView.Source = new ItemsDataSource(ViewModel);

            Title = ViewModel.UIModel.Title;
        }

        //    public override void ViewDidAppear(bool animated)
        //    {
        //        base.ViewDidAppear(animated);

        //        //if (ViewModel.Items.Count == 0)
        //        //ViewModel.LoadItemsCommand.Execute(null);
        //    }

        //    public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        //    {
        //        if (segue.Identifier == "NavigateToItemDetailSegue")
        //        {
        //            var controller = segue.DestinationViewController as BrowseItemDetailViewController;
        //            var indexPath = TableView.IndexPathForCell(sender as UITableViewCell);
        //            var item = ViewModel.Items[indexPath.Row];

        //            controller.ViewModel = new ItemDetailViewModel(item);
        //        }
        //        else
        //        {
        //            var controller = segue.DestinationViewController as ItemNewViewController;
        //            controller.ViewModel = ViewModel;
        //        }
        //    }

        //    void RefreshControl_ValueChanged(object sender, EventArgs e)
        //    {
        //        if (!ViewModel.IsBusy && refreshControl.Refreshing)
        //            ViewModel.ReloadItemsAction();
        //    }

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

        //    void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //    {
        //        InvokeOnMainThread(() => TableView.ReloadData());
        //    }
        //}

        //class ItemsDataSource : UITableViewSource
        //{
        //;

        //ItemsViewModel viewModel;

        //public ItemsDataSource(ItemsViewModel viewModel)
        //{
        //    this.viewModel = viewModel;
        //}

        public nint RowsInSection(UITableView tableview, nint section) => ViewModel.Items.Count;
        public nint NumberOfSections(UITableView tableView) => 1;

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CELL_IDENTIFIER, indexPath);

            var item = ViewModel.Items[indexPath.Row];
            cell.TextLabel.Text = item.Text;
            cell.DetailTextLabel.Text = item.Description;
            cell.LayoutMargins = UIEdgeInsets.Zero;

            return cell;
        }
    }
}
