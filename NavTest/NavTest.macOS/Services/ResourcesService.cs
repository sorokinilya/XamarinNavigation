using System;
using System.Collections.Generic;
using NavTest.Services.Resources;

namespace NavTest.macOS.Services
{
    public class ResourcesService : BaseResourcesService
    {
        public ResourcesService() : base()
        {
        }

        protected override Dictionary<ImageKey, string> defaultImages()
        {
            return new Dictionary<ImageKey, string>();
        }
    }
}
