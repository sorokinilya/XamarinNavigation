using NavTest.Services.Store;

namespace NavTest.Services
{
    public partial class ServiceLayer
    {
        public BaseRouter Router
        {
            get
            {
                return this.Get<BaseRouter>();
            }
        }

        public DataStore DataStore
        {
            get
            {
                return this.Get<DataStore>();
            }
        }
    }
}

