namespace Panther_Services.Pages;

public partial class Marketing_Page : ContentPage
{
	public Marketing_Page()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Calc_Page());
    }
}