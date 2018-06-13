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
                                         Dictionary<Color, Int32> colors)
        {
            var serviceLayer = ServiceLayer.Instance;
            DataStore store = new DataStore();
            serviceLayer.Register(store);
            serviceLayer.Register(router);
            var newColors = ColorfMethods.defaultColors;
            foreach (KeyValuePair<Color, Int32> pair in colors)
            {
                newColors[pair.Key] = pair.Value;
            }
            ResourcesService resourcesService = new ResourcesService(newColors);
            serviceLayer.Register(resourcesService);
            store.Initialize();
            router.Initialize();
        }
    }
}
