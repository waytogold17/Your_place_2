using hotellerie.Models;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace hotellerie.View;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private void btnRegister_Clicked(object sender, EventArgs e)
    {

    }

    private void InitializeEventHandlers()
    {
        entryName.TextChanged += EntryNameSurname_TextChanged;
       
        entryEmail.TextChanged += EntryEmail_TextChanged;
        entryPhoneNumber.TextChanged += EntryPhoneNumber_TextChanged;
        entryPassword.TextChanged += EntryPassword_TextChanged;
        entryConfirmPassword.TextChanged += EntryConfirmPassword_TextChanged;
    }
    private void EntryNameSurname_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool isValid = !string.IsNullOrWhiteSpace(entryName.Text) && entryName.Text.All(c => char.IsLetter(c));

        if (!isValid)
        {
            DisplayAlert("Erreur", "Le nom et le pr�nom doivent contenir uniquement des lettres.", "OK");
            entryName.Text = string.Empty;
        }
    }

    private void EntryEmail_TextChanged(object sender, TextChangedEventArgs e)
    {
        string email = e.NewTextValue.Trim();

        bool isValid = !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");


        if (!isValid)
        {
            DisplayAlert("Erreur", "Veuillez saisir une adresse e-mail valide.", "OK");
            entryEmail.Text = string.Empty;
        }
    }

    private void EntryPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
    {
        string phoneNumber = e.NewTextValue.Trim();

        bool isValid = !string.IsNullOrWhiteSpace(phoneNumber) && int.TryParse(phoneNumber, out _);


        if (!isValid)
        {
            DisplayAlert("Erreur", "Le num�ro de t�l�phone doit contenir uniquement des chiffres.", "OK");
            entryPhoneNumber.Text = string.Empty;
        }
    }

    private void EntryPassword_TextChanged(object sender, TextChangedEventArgs e)
    {
        string password = e.NewTextValue;

        bool isValid = !string.IsNullOrWhiteSpace(password) &&
                       password.Length >= 6 &&
                       password.Any(char.IsDigit) &&
                       password.Any(char.IsUpper);

        if (!isValid)
        {
            DisplayAlert("Erreur", "Le mot de passe doit contenir au moins 6 caract�res, dont au moins un chiffre et une lettre majuscule.", "OK");
            entryPassword.Text = string.Empty;
        }
    }

    private void EntryConfirmPassword_TextChanged(object sender, TextChangedEventArgs e)
    {
        string confirmPassword = e.NewTextValue;
        string password = entryPassword.Text;

        bool isValid = !string.IsNullOrWhiteSpace(confirmPassword) &&
                       string.Equals(confirmPassword, password);

        if (!isValid)
        {
            DisplayAlert("Erreur", "La confirmation du mot de passe ne correspond pas au mot de passe saisi.", "OK");
            entryConfirmPassword.Text = string.Empty;
        }
    }

    private bool ValidateInputs()
    {
        string name = entryName.Text.Trim();
        string email = entryEmail.Text.Trim();
        string phoneNumber = entryPhoneNumber.Text.Trim();
        string password = entryPassword.Text;
        string confirmPassword = entryConfirmPassword.Text;

        if (string.IsNullOrWhiteSpace(name))
        {
            // Afficher un message d'erreur
            DisplayAlert("Erreur", "Veuillez saisir votre nom et pr�nom.", "OK");
            return false;
        }

        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
        {
            // Afficher un message d'erreur
            DisplayAlert("Erreur", "Veuillez saisir une adresse e-mail valide.", "OK");
            return false;
        }

        if (string.IsNullOrWhiteSpace(phoneNumber) || !phoneNumber.All(char.IsDigit))
        {
            // Afficher un message d'erreur
            DisplayAlert("Erreur", "Veuillez saisir un num�ro de t�l�phone valide.", "OK");
            return false;
        }

        if (password.Length < 6 || !password.Any(char.IsDigit) || !password.Any(char.IsUpper))
        {
            // Afficher un message d'erreur
            DisplayAlert("Erreur", "Veuillez saisir un mot de passe valide (au moins 6 caract�res, contenant au moins un chiffre et une lettre majuscule).", "OK");
            return false;
        }

        if (password != confirmPassword)
        {
            // Afficher un message d'erreur
            DisplayAlert("Erreur", "Les mots de passe saisis ne correspondent pas.", "OK");
            return false;
        }

        return true;
    }

    private void InsertUserData()
    {
        // Valider les champs de saisie
        if (!ValidateInputs())
        {
            DisplayAlert("Erreur", "Veuillez v�rifier vos donn�es saisies", "OK");
            return;
        }

        // R�cup�rer les valeurs des champs de saisie
        string name = entryName.Text.Trim();
        string email = entryEmail.Text.Trim();
        string phoneNumber = entryPhoneNumber.Text.Trim();
        string password = entryPassword.Text;

        // Cr�er un objet utilisateur avec les donn�es saisies
        User user = new ()
        {
            Name = name,
            Email = email,
            PhoneNumber = phoneNumber,
            Password = password
        };

        // Ins�rer l'utilisateur dans la base de donn�es
        using (var dbContext = new HotelsDbContext())
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        // Afficher un message de succ�s ou effectuer une autre action
        DisplayAlert("Succ�s", "Votre compte a �t� cr�� avec succ�s !", "OK");
    }

}