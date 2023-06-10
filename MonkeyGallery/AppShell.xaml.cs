using MonkeyGallery.Views;
using System.Windows.Input;

namespace MonkeyGallery;

public partial class AppShell : Shell
{
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }

    void RegisterRoutes()
    {
        Routing.RegisterRoute("monkey", typeof(MonkeyView));

       

    }

}
