using System;
namespace NavTest.ViewModels.Base
{
    public interface IBaseViewModel
    {
        bool Busy { get; }

        Action ReleaseModelAction { get; }
    }

}
