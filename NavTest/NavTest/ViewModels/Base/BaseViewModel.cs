using System;
using NavTest.ViewModels.Base;

namespace NavTest
{
    public class BaseViewModel<T> : IBaseViewModel where T : class, new()
    {
        public T Resources { get; private set; } = new T();

        public Action ShowItems { get; set; }
        public Action ShowAbout { get; set; }
        public Action ShowNewItem { get; set; }
        public Action Release { get; set; }


        //~BaseViewModel()
        //{
        //    var a = 10;
        //}
    }
}
