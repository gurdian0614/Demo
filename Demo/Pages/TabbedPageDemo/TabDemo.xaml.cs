namespace Demo.Pages.TabbedPageDemo;

public partial class TabDemo : TabbedPage
{
	public TabDemo()
	{
		InitializeComponent();
	}

    /**
     * == Igual if (a == b)....
     * != Distinto o diferente de if (a != b)
     * < Menor que if (a < 0) 
     * <= Menor o igual que if (a <= 0)
     * > Mayor que if (a > 0)
     * >= Mayor o igual que if (a >= 0)
     * 
     * && and if (a > 0 && b < 9)
     * || or if (a > 0 || b < 9)
     */
    private void btnSumar_Clicked(object sender, EventArgs e)
    {
		try
		{
            double n1, n2, suma;

            /*if (txtValor1.Text != "" && txtValor2.Text != "")
            {
                n1 = Double.Parse(txtValor1.Text);
                n2 = Double.Parse(txtValor2.Text);

                suma = n1 + n2;

                txtResultado.Text = suma.ToString();
            } else
            {
                txtResultado.Text = "Los campos estan vacioss";
            }*/

            if (txtValor1.Text == null || txtValor1.Text == "")
            {
                DisplayAlert("Alerta", "Campo valor 1 esta vacio", "Aceptar");
            } else if (txtValor1.Text == null || txtValor2.Text == "")
            {
                DisplayAlert("Alerta", "Campo valor 2 esta vacio", "Aceptar");
            } else {
                n1 = Double.Parse(txtValor1.Text);
                n2 = Double.Parse(txtValor2.Text);

                suma = n1 + n2;

                txtResultado.Text = $"La suma es: {suma.ToString()}";
                btnSumar.IsEnabled = false; 
            }
        } catch (Exception ex)
		{
            DisplayAlert("Alerta", $"Ha ocurrido un error. {ex.Message}", "Aceptar");
		}		
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        limpiar();
    }

    /**
     * Método para limpiar campos
     * 
     * author Roger Gurdian
     */
    private void limpiar()
    {
        txtValor1.Text = "";
        txtValor2.Text = "";
        txtResultado.Text = "";
        btnSumar.IsEnabled = true;

        //txtValor1.Text = txtValor2.Text = txtResultado.Text = "";
    }
}