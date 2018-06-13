using System;
using UIKit;

namespace NavTest.iOS.Extension
{
    public static class ExtensionMethods
    {
        public static UIColor ToUIColor(this Int32 rgb)
        {
            return UIColor.FromRGB((rgb & 0x00FF0000) >> 16, (rgb & 0x0000FF00) >> 8, (rgb & 0x000000FF));
        }
    }
}
