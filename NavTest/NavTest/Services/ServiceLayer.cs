using System;
using System.Collections.Generic;

namespace NavTest.Services
{
    internal partial class ServiceLayer
    {
        static readonly ServiceLayer instance = new ServiceLayer();
        private readonly Dictionary<Type, object> registeredServices = new Dictionary<Type, object>();

        internal static ServiceLayer Instance => instance;

        internal void Register<T>(T service) where T : class
        {
            registeredServices[typeof(T)] = service;
        }

        internal T Get<T>() where T : class
        {
            return registeredServices[typeof(T)] as T;
        }
    }
}
