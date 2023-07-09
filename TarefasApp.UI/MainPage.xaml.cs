using TarefasApp.UI.Views;

namespace TarefasApp.UI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Método para evento Tapped
	/// </summary>
	private async void EsqueciMinhaSenhaTapped(object sender, EventArgs e)
	{
		//redirecionamento..
		await Navigation.PushAsync(new PasswordRecover());
	}

    /// <summary>
    /// Método para evento Tapped
    /// </summary>
    private async void CriarContaTapped(object sender, EventArgs e)
    {
        //redirecionamento..
        await Navigation.PushAsync(new Register());
    }
}

