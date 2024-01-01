namespace FamilyApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodPage());
        }

        private async void TreeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TreePage());
        }
    }
}