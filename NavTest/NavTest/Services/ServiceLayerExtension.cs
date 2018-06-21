using NavTest.Services.Resources;
using NavTest.Services.Store;

namespace NavTest.Services
{
    public partial class ServiceLayer
    {
        public BaseRouter Router => this.Get<BaseRouter>();

        public DataStore DataStore => this.Get<DataStore>();

        internal BaseResourcesService ResourcesService => this.Get<BaseResourcesService>();
    }
}

