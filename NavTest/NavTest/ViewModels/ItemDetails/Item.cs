using System;
namespace NavTest.ViewModels.ItemDetail
{
    public struct Item
    {
        public string Text { get; }
        public string Description { get; }

        internal Item(string text, string description)
        {
            this.Text = text;
            this.Description = description;
        }

    }
}
