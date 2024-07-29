using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class TelaEscolhas : ContentPage
    {
        public TelaEscolhas()
        {
            InitializeComponent();
        }

        private void OnContasAPagarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Contas a Pagar" button click
            DisplayAlert("Contas a Pagar", "Contas a Pagar button clicked", "OK");
        }

        private void OnDevedoresButtonClicked(object sender, EventArgs e)
        {
            // Handle "Devedores" button click
            DisplayAlert("Devedores", "Devedores button clicked", "OK");
        }

        private void OnAReceberButtonClicked(object sender, EventArgs e)
        {
            // Handle "A Receber" button click
            DisplayAlert("A Receber", "A Receber button clicked", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Handle back button click
            Navigation.PopAsync();
        }
    }
}