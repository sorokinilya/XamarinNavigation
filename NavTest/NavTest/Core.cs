using NavTest.Services;

namespace NavTest
{
    public class Core
    {

        public static void Initialize(BaseRouter router)
        {
            DataStore store = new DataStore();
            ServiceLayer.Instance.Register(store);
            ServiceLayer.Instance.Register(router);
            store.Initialize();
            router.Initialize();
        }
    }
}
