using System;
namespace NavTest.ViewModels.Base
{
    public interface IBaseViewModel
    {
        bool IsLoading { get; set; }

        Action ShowItems { get; set; }
        Action ShowAbout { get; set; }
        Action ShowNewItem { get; set; }
        Action ReleaseModel { get; set; }
    }
}
