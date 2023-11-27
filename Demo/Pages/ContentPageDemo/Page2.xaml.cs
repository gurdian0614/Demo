namespace Demo.Pages.ContentPageDemo;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void btnRegresarPagina1_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new Page1());
    }
}