namespace Panther_Services.Pages;

public partial class Aplicações_Simples_Page : ContentPage
{
	public Aplicações_Simples_Page()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Calc_Page());
    }
}