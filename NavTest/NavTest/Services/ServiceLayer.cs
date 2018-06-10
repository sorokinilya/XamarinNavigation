using System;
using System.Collections.Generic;

namespace NavTest.Services
{
    public partial class ServiceLayer
    {
        static readonly ServiceLayer instance = new ServiceLayer();
        private readonly Dictionary<Type, object> registeredServices = new Dictionary<Type, object>();

        public static ServiceLayer Instance => instance;

        public void Register<T>(T service) where T : class
        {
            registeredServices[typeof(T)] = service;
        }

        public T Get<T>() where T : class
        {
            return registeredServices[typeof(T)] as T;
        }
    }
}
