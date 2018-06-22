using AppKit;
using Foundation;
using NavTest.macOS.Services;
using NavTest.Services;

namespace NavTest.macOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            var viewController = NSApplication.SharedApplication.KeyWindow.ContentViewController;
            Core.Initialize(new Router(viewController), new ResourcesService());
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        partial void aboutAction(AppKit.NSMenuItem sender)
        {
            ServiceLayer.Instance.Router.ShowAbout();
        }

        partial void newAction(AppKit.NSMenuItem sender)
        {
            ServiceLayer.Instance.Router.ShowNewItem();
        }
    }
}
