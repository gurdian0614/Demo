namespace Demo.Pages.ContentPageDemo;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void btnIrPagina2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new Page2());
    }
}