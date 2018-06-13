using AppKit;
using CoreGraphics;
using Foundation;
using Xamarin.Forms.Platform.MacOS;

namespace SnipInsight.Forms.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        private NSWindow _window;

        public AppDelegate()
        {
            var rect = new CGRect(200, 1000, 1024, 768);
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
            _window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
        }

        public override NSWindow MainWindow => _window;

        public override void DidFinishLaunching(NSNotification notification)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            base.DidFinishLaunching(notification);
        }
    }
}
