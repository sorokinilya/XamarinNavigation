using System;
using System.Collections.ObjectModel;
using Foundation;
using NavTest.ViewModels.Items;
using UIKit;

namespace NavTest.iOS.ViewControllers.Browse
{
    internal class ItemsDataSource : UITableViewSource
    {
        static readonly NSString CELL_IDENTIFIER = new NSString("ITEM_CELL");

        private ObservableCollection<Item> items;

        public ItemsDataSource(ObservableCollection<Item> items)
        {
            this.items = items;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => this.items.Count;
        public override nint NumberOfSections(UITableView tableView) => 1;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CELL_IDENTIFIER, indexPath);

            var item = this.items[indexPath.Row];
            cell.TextLabel.Text = item.Text;
            cell.DetailTextLabel.Text = item.Description;
            cell.LayoutMargins = UIEdgeInsets.Zero;
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            this.items[indexPath.Row].SelectAction();
        }

    }
}
