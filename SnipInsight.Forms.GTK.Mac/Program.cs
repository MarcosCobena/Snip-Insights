using Xamarin.Forms.Platform.GTK;

namespace SnipInsight.Forms.GTK.Mac
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            global::Xamarin.Forms.Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle(App.Title);
            window.Show();

            Gtk.Application.Run();
        }
    }
}
