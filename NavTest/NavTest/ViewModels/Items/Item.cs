using System;
namespace NavTest.ViewModels.Items
{
    public struct Item
    {
        internal int Id { get; }
        public string Text { get; }
        public string Description { get; }

        public Action SelectAction { get; }

        internal Item(int id, string text, string description, Action selectAction)
        {
            this.Id = id;
            this.Text = text;
            this.Description = description;
            this.SelectAction = selectAction;
        }

    }
}
