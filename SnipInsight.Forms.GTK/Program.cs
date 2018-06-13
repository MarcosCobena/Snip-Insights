using System;
using Xamarin.Forms.Platform.GTK;

namespace SnipInsight.Forms.GTK
{
    public class Program
    {
        [STAThread]
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
