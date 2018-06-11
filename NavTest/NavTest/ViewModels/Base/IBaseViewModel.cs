using System;
namespace NavTest.ViewModels.Base
{
    public interface IBaseViewModel
    {
        Action ShowItems { get; set; }
        Action ShowAbout { get; set; }
        Action ShowNewItem { get; set; }
        Action Release { get; set; }
    }
}
