using System;
namespace NavTest.Services
{
    public interface IRouter 
    {
        void Initialize();

        void ShowItems();

        void ShowNewItem();

        void ShowAbout();

        void ShowWeb(string url);
    }
}
