

using BookShop.Pages;

namespace BookShop;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

	private async void top_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new About());
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new grouping());
    }

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AudioBooks());
    }

	private async void Button_Clicked_2(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new FreeBooks());
    }

	private async void Button_Clicked_3(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new HotOffers());
    }

	private async void Button_Clicked_4(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Podcast());
    }

	private async void Button_Clicked_5(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new subscription());
    }

	private async void Button_Clicked_6(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new EBooks());
    }

	//image buttons
	private async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new EBooks());
    }

	private async void ImageButton_Clicked_1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new EBooks());
    }

	private async void ImageButton_Clicked_2(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new EBooks());
    }

	private async void ImageButton_Clicked_3(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new EBooks());
    }

    //3 buttons in boxviews
    private async void Button_Clicked_7(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new HotOffers());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Podcast());
    }

    //Ebooks
    private async void Button_Clicked_10(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_7(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_10(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    private async void ImageButton_Clicked_11(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EBooks());
    }

    //saved
    private async void Button_Clicked_11(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new saved());
    }

    private async void ImageButton_Clicked_12(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new saved());
    }

    private async void ImageButton_Clicked_13(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new saved());
    }

    private async void ImageButton_Clicked_14(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new saved());
    }

    private async void ImageButton_Clicked_15(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new saved());
    }

    //audio books
    private async void Button_Clicked_12(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void ImageButton_Clicked_16(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void ImageButton_Clicked_17(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void ImageButton_Clicked_18(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void ImageButton_Clicked_19(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void ImageButton_Clicked_20(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }

    private async void ImageButton_Clicked_21(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AudioBooks());
    }



}

