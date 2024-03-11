namespace Panther_Services.Pages;

public partial class Front_End_Page : ContentPage
{
	public Front_End_Page()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Calc_Page());
    }
}