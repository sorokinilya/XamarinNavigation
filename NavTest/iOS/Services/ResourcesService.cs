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

        protected override Dictionary<ImageKey, IImage> defaultImages()
        {
            return new Dictionary<ImageKey, IImage>
            {
                { ImageKey.TB_ListsImage, new Image("TB_Items") },
                { ImageKey.TB_AboutImage, new Image("TB_About")}
            };
        }
    }
}
