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
    }
}
