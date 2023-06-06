namespace hotellerie.View;

public partial class Connexionpage : ContentPage
{
	public Connexionpage()
	{
		InitializeComponent();
	}

    public void RegistrationRedirect(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registration());
    }

    private void LoginRedirect(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}