using System;
using System.Diagnostics;
using NavTest.Services;
using NavTest.ViewModels.Base;

namespace NavTest.ViewModels.ItemDetail
{
    internal class ItemDetailController : BaseController<ItemDetailViewModel>
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

        internal ItemDetailController(BaseRouter router) : base(new ItemDetailViewModel())
        {
            this.viewModel.ReleaseModelAction = () =>
            {
                Debug.WriteLine("Released" + this.GetType());
                router.ReleaseConroller(this.GetType());
            };
        }
    }
}
