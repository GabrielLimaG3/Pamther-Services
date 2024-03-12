namespace Panther_Services.Pages;

public partial class Calc_Page : ContentPage
{
	public Calc_Page()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
	{
		int vr = int.Parse(Entry_valor_horas.Text) * 50;
		lb_res.Text = vr.ToString();

    }
}