using System;
namespace NavTest.Services
{
    public partial class ServiceLayer
    {
        public IRouter Router
        {
            get
            {
                return this.Get<IRouter>();
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
