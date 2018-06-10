using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NavTest.ViewModels.Base;

namespace NavTest
{
    public class BaseViewModel<T> : IBaseViewModel where T : class, new()
    {
        public T UIModel { get; private set; } = new T();

        public Action ShowItems { get; set; }
        public Action ShowAbout { get; set; }
        public Action ShowNewItem { get; set; }

    }
}
