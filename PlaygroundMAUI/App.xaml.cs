namespace PlaygroundMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // Android - CollectionView issues exists when rotating to portrait-landscape-portrait and the page is not inside a Shell
        //MainPage = new MainPage();
        MainPage = new NavigationPage(new MainPage());

        // Android - CollectionView issue does not happen when the page is inside a Shell
        //MainPage = new AppShell();

        // iOS issue happens even if page is in a Shell or not
    }
}