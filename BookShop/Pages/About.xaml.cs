namespace BookShop.Pages;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
    }
}