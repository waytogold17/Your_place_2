using hotellerie.Models;
using Microsoft.EntityFrameworkCore;

namespace hotellerie.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void AuthenticateUser(object sender, EventArgs e)
    {
        string email = EntryEmail.Text;
        string password = EntryPassword.Text;
        DisplayAlert("Reussite", "authentification r�ussie", "OK");
        Navigation.PushAsync(new HomePage2());
    }

    //private void AuthenticateUser()
    //{
    //    string email = EntryEmail.Text;
    //    string password = EntryPassword.Text;

    //    // V�rification de l'authentification
    //    var user = HotelsDbContext.User.FirstOrDefault(u => u.Email == email && u.Password == password);

    //    if (user != null)
    //    {
    //        DisplayAlert("Reussite", "authentification r�ussie", "OK");
    //        Navigation.PushAsync(new HomePage());
    //    }
    //    else
    //    {
    //        DisplayAlert("Erreur", "V�rifiez vos identifiants de connexion et r�essayez, s'il vous pla�t.", "OK");
    //        EntryEmail.Text = string.Empty;
    //        EntryPassword.Text = string.Empty;
    //    }
    //}

}