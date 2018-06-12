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

        internal ObservableCollection<Item> Items { get; set; }

        public ItemsDataSource(ObservableCollection<Item> items)
        {
            this.Items = items;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => this.Items.Count;
        public override nint NumberOfSections(UITableView tableView) => 1;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CELL_IDENTIFIER, indexPath);

            var item = this.Items[indexPath.Row];
            cell.TextLabel.Text = item.text;
            cell.DetailTextLabel.Text = item.description;
            cell.LayoutMargins = UIEdgeInsets.Zero;

            return cell;
        }
    }
}
