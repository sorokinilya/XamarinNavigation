using System;
namespace NavTest.ViewModels.ItemDetail
{
    public struct Item
    {
        public readonly string text;
        public readonly string description;

        internal Item(string text, string description)
        {
            this.text = text;
            this.description = description;
        }

    }
}
