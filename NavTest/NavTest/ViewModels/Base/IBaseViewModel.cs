using System;
namespace NavTest.ViewModels.Base
{
    public interface IBaseViewModel
    {
        Action ReleaseModelAction { get; }
    }

}
