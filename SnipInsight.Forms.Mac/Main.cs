using AppKit;

namespace SnipInsight.Forms.Mac
{
    public static class MainClass
    {
        public static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.Main(args);
        }
    }
}
