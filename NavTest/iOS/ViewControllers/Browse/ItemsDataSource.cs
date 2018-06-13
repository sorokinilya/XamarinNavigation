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
        private Action<int> action;

        public ItemsDataSource(ObservableCollection<Item> items, Action<int> action)
        {
            this.items = items;
            this.action = action;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => this.items.Count;
        public override nint NumberOfSections(UITableView tableView) => 1;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CELL_IDENTIFIER, indexPath);

            var item = this.items[indexPath.Row];
            cell.TextLabel.Text = item.text;
            cell.DetailTextLabel.Text = item.description;
            cell.LayoutMargins = UIEdgeInsets.Zero;
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            this.action(this.items[indexPath.Row].id);
        }

    }
}
