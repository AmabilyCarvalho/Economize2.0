using System;
using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Lógica de autenticação
            if (IsValidLogin(email, password))
            {
                DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");
                // Navegar para a próxima página ou funcionalidade
            }
            else
            {
                DisplayAlert("Erro", "Email ou senha inválidos.", "OK");
            }
        }

        private bool IsValidLogin(string email, string password)
        {
            // Adicione a lógica de validação do login aqui
            return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
        }
    }
}