namespace Panther_Services.Pages;

public partial class Calc_Page : ContentPage
{
	public Calc_Page()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
	{
		lb_res.Text = Entry_valor_horas.Text.ToString();
    }
}