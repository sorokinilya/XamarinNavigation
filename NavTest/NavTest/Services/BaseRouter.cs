﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using NavTest.ViewModels.About;
using NavTest.ViewModels.ItemNew;
using NavTest.ViewModels.Items;

namespace NavTest.Services
{
    public abstract class BaseRouter
    {
        private readonly Dictionary<Type, object> registeredContrellers = new Dictionary<Type, object>();

        protected BaseRouter()
        {
        }

        public abstract void Initialize();

        public void ShowItems()
        {
            this.ShowItems(this.GetController(() => new ItemsController(this)).ViewModel);
        }

        public void ShowNewItem()
        {
            this.ShowNewItem(this.GetController(() => new AddItemController(this)).ViewModel);
        }

        public void ShowAbout()
        {
            this.ShowAbout(this.GetController(() => new AboutController(this)).ViewModel);
        }

        protected abstract void ShowItems(ItemsViewModel viewModel);

        protected abstract void ShowNewItem(AddItemViewModel viewModel);

        protected abstract void ShowAbout(AboutViewModel viewModel);

        public abstract void ShowWeb(string url);

        internal void ReleaseConroller(Type type)
        {
            this.registeredContrellers.Remove(type);
        }

        protected T GetController<T>(Func<T> make) where T : class
        {
            Type type = typeof(T);
            var controller = this.registeredContrellers.GetValueOrDefault(type);
            if (controller == null)
            {
                object[] args = { this };
                controller = make();
                this.registeredContrellers[type] = controller;
            }
            return controller as T;
        }

    }
}