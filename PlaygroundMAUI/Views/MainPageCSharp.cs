using PlaygroundMAUI.ViewModels;

namespace PlaygroundMAUI.Views;

public class MainPageCSharp : ContentPage
{
    public MainPageCSharp()
    {
        BindingContext = new MainViewModel();
        LoadPage();
    }

    private void LoadPage()
    {
        var firstLayout = new StackLayout
        {
            Padding = 0,
            Spacing = 4
        };

        for (int i = 0; i < 20; i++)
        {
            var label = new Label()
            {
                Text = $"Lorem ipsum dolor sit amet {i}"
            };

            firstLayout.Children.Add(label);
        }

        var switchControl = new Switch();
        var vm = BindingContext as MainViewModel;
        switchControl.SetBinding(Switch.IsToggledProperty, nameof(vm.BottomContentVisible), BindingMode.TwoWay);

        var secondLayout = new StackLayout
        {
            Padding = 0,
            Spacing = 4
        };

        for (int i = 0; i < 10; i++)
        {
            var label = new Label()
            {
                Text = $"Lorem ipsum dolor sit amet second layout {i}"
            };

            secondLayout.Children.Add(label);
        }

        secondLayout.SetBinding(StackLayout.IsVisibleProperty, nameof(vm.BottomContentVisible), BindingMode.TwoWay);

        var entry = new Entry()
        {
            Placeholder = "Lorem ipsum dolor sit amet",
            Margin = new Thickness(0, 0, 0, 0)
        };
        entry.SetBinding(Entry.IsVisibleProperty, nameof(vm.BottomContentVisible), BindingMode.TwoWay);

        var button = new Button
        {
            Text = "Lorem ipsum",
            Padding = new Thickness(0, 25, 0, 0),
            BackgroundColor = Colors.MediumPurple,
            BorderWidth = 1,
            BorderColor = Colors.Blue,
        };
        button.SetBinding(Button.CommandProperty, nameof(vm.TapButtonCommand));

        var mainContainer = new StackLayout
        {
            Spacing = 25,
            Children =
            {
                firstLayout,
                switchControl,
               secondLayout,
               entry,
               button,
            }
        };

        var scrollView = new ScrollView
        {
            Content = mainContainer,
        };

        Content = scrollView;
    }
}