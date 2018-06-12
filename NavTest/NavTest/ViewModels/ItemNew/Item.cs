using System;
namespace NavTest.ViewModels.ItemNew
{
    public struct Item
    {
        public readonly string text;
        public readonly string description;

        public Item(string text, string description)
        {
            this.text = text;
            this.description = description;
        }
    }
}
