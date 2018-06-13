﻿using System;
namespace NavTest.ViewModels.Items
{
    public struct Item
    {
        public readonly int id;
        public readonly string text;
        public readonly string description;

        internal Item(int id, string text, string description)
        {
            this.id = id;
            this.text = text;
            this.description = description;
        }

    }
}