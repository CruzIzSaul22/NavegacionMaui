namespace NavegacionMaui.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		InitializeComponent();
	}

	private async void OnVerInformacionClicked(object sender, EventArgs e)
    {
		// Abre la página sociada a esta ruta.
        await Shell.Current.GoToAsync("informacion");
    }

}