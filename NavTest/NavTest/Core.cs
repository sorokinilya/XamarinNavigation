using NavTest.Services;

namespace NavTest
{
    public class Core
    {

        public static void Initialize(IRouter router)
        {
            IDataStore store = new MockDataStore();
            ServiceLayer.Instance.Register(store);
            ServiceLayer.Instance.Register(router);
        }
    }
}
