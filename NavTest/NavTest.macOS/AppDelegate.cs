using AppKit;
using Foundation;
using NavTest.macOS.Services;

namespace NavTest.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            Core.Initialize(new Router(), new ResourcesService());
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
