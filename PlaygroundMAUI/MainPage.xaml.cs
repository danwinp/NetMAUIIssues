using PlaygroundMAUI.ViewModels;

namespace PlaygroundMAUI;

public partial class MainPage : ContentPage
{
    private int count = 0;

    public MainPage()
    {
        BindingContext = new MainViewModel();
        InitializeComponent();
    }
}