using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class TelaInicio : ContentPage
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
            DisplayAlert("Login", "Login button clicked", "OK");
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Cadastro();
            DisplayAlert("Register", "Register button clicked", "OK");
        }
    }
}