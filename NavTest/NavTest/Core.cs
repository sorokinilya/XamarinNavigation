using System;
using System.Collections.Generic;
using NavTest.Services;
using NavTest.Services.Resources;
using NavTest.Services.Store;

namespace NavTest
{
    public static class Core
    {

        public static void Initialize(BaseRouter router,
                                      BaseResourcesService resourcesService = null)
        {
            var serviceLayer = ServiceLayer.Instance;
            DataStore store = new DataStore();
            serviceLayer.Register(store);
            serviceLayer.Register(router);
            if (resourcesService == null)
            {
                resourcesService = new BaseResourcesService();
            }
            serviceLayer.Register(resourcesService);
            resourcesService.Initialize();
            store.Initialize();
            router.Initialize();
        }
    }
}
