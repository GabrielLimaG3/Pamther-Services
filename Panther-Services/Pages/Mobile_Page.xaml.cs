namespace Panther_Services.Pages;

public partial class Mobile_Page : ContentPage
{
	public Mobile_Page()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Calc_Page());
    }
}