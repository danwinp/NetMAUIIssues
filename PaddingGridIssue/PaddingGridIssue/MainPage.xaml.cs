namespace PaddingGridIssue
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void NextPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NextPage());
        }
    }
}