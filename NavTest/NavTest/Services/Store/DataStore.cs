﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavTest.Services.Store
{
    class DataStore
    {
        List<Item> items;

        internal DataStore()
        {
            items = new List<Item>();
        }

        internal void Initialize()
        {
            var _items = new List<Item>
            {
                new Item { Id = Guid.NewGuid().GetHashCode(), Text = "First item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().GetHashCode(), Text = "Second item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().GetHashCode(), Text = "Third item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().GetHashCode(), Text = "Fourth item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().GetHashCode(), Text = "Fifth item", Description="This is a nice description"},
                new Item { Id = Guid.NewGuid().GetHashCode(), Text = "Sixth item", Description="This is a nice description"},
            };
            foreach (Item item in _items)
            {
                this.items.Add(item);
            }
        }

        internal async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);
            await Task.Delay(2500);
            return await Task.FromResult(true);
        }

        internal async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);
            await Task.Delay(2700);
            return await Task.FromResult(true);
        }

        internal async Task<bool> DeleteItemAsync(int id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);
            await Task.Delay(2500);
            return await Task.FromResult(true);
        }

        internal async Task<Item> GetItemAsync(int id)
        {
            await Task.Delay(2500);
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        internal async Task<IEnumerable<Item>> GetItemsAsync()
        {
            await Task.Delay(2500);
            return await Task.FromResult(items);
        }
    }
}
