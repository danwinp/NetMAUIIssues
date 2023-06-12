using PlaygroundMAUI.Views;

namespace PlaygroundMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPageCSharp());
    }
}