using System;
using System.Collections.Generic;
using NavTest.Services.Resources;
using NavTest.iOS.Extension;

namespace NavTest.iOS.Services
{
    public class ResourcesService : BaseResourcesService
    {
        public ResourcesService() : base()
        {
        }

        protected override Dictionary<ImageKey, string> defaultImages()
        {
            return new Dictionary<ImageKey, string>
            {
                { ImageKey.TB_ListsImage, "TB_Items" },
                { ImageKey.TB_AboutImage, "TB_About"}
            };
        }
    }
}
