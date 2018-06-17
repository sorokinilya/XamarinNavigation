using System;
using NavTest.Services.Resources;
using UIKit;

namespace NavTest.iOS.Extension
{
    public class Image: UIImage, IImage
    {
        public Image(string name) : base(name)
        {}
    }
}
