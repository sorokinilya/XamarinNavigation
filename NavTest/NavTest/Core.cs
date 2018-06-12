using System;
using System.Collections.Generic;
using NavTest.Services;
using NavTest.Services.Resources;
using NavTest.Services.Store;

namespace NavTest
{
    public class Core
    {

        public static void Initialize<C>(BaseRouter router,
                                      Func<Int32, C> colorMaker,
                                         Dictionary<Color, Int32> colors)
        {
            var serviceLayer = ServiceLayer.Instance;
            DataStore store = new DataStore();
            serviceLayer.Register(store);
            serviceLayer.Register(router);
            ResourcesService<C> resourcesService = new ResourcesService<C>(colorMaker);
            serviceLayer.Register(resourcesService);
            var newColors = ColorfMethods.defaultColors;
            foreach (KeyValuePair<Color, Int32> pair in colors)
            {
                newColors[pair.Key] = pair.Value;
            }
            resourcesService.Initialize(newColors);
            store.Initialize();
            router.Initialize();
        }
    }
}
