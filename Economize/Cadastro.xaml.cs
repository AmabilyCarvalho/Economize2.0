using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for the register button click
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            // Example validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                DisplayAlert("Erro", "Todos os campos são obrigatórios.", "OK");
                return;
            }

            if (password != confirmPassword)
            {
                DisplayAlert("Erro", "As senhas não coincidem.", "OK");
                return;
            }

            Application.Current.MainPage = new TelaEscolhas();
            DisplayAlert("Sucesso", "Cadastro realizado com sucesso!", "OK");
        }
      private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicio();
            Navigation.PopAsync();
        }

    }
}