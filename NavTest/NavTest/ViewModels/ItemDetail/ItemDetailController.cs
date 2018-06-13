using System;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemDetail
{
    internal class ItemDetailController: BaseController<ItemDetailViewModel>
    {
        private int id = 0;
        internal int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    //
                }
            }
        }

        internal ItemDetailController(BaseRouter router) : base(router, new ItemDetailViewModel())
        {
        }
    }
}
