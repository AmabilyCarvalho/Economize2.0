using System;
using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class Devedor : ContentPage
    {
        public Devedor()
        {
            InitializeComponent();
        }

        private void OnAddDebtorButtonClicked(object sender, EventArgs e)
        {
            // Adicionar novo campo de devedor
            Entry newDebtorEntry = new Entry
            {
                Placeholder = "Novo devedor",
                BackgroundColor = Colors.White,
                TextColor = Colors.Black
            };
            // Adiciona o novo campo ao StackLayout
            //(Content as Grid).Children[1].Add(newDebtorEntry);
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaEscolhas();
            Navigation.PopAsync();
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de configurações
            // Navigation.PushAsync(new SettingsPage());
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Implementar funcionalidade de deletar (devedores, etc.)
        }

        private void BotaoSalvar(object sender, EventArgs e)
        {
            
        }

    }
    
}