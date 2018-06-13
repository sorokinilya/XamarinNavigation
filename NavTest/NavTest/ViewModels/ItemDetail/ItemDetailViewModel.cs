﻿using System;

namespace NavTest.ViewModels.ItemDetail
{
    public class ItemDetailViewModel : BaseViewModel<ItemDetailResourcesModel>
    {
        public Item Item { get; set; }

        internal ItemDetailViewModel() : base(new ItemDetailResourcesModel()) 
        {
        }
    }
}
