using Demo.Pages.NavigationPageDemo;

namespace Demo.Pages.NewFolder;

public partial class Navigation1 : ContentPage
{
	public Navigation1()
	{
		InitializeComponent();
	}

    private void btnIrPagina2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Navigation2());
    }
}