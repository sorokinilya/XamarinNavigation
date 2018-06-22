using NavTest.Services.Resources;
using NavTest.Services.Store;

namespace NavTest.Services
{
    partial class ServiceLayer
    {
        internal BaseRouter Router => this.Get<BaseRouter>();

        internal DataStore DataStore => this.Get<DataStore>();

        internal BaseResourcesService ResourcesService => this.Get<BaseResourcesService>();
    }
}

