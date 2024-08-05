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
            Application.Current.MainPage = new Contas();
            DisplayAlert("Contas a Pagar", "Contas a Pagar button clicked", "OK");
        }

        private void OnDevedoresButtonClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Devedor();
            DisplayAlert("Devedores", "Devedores button clicked", "OK");
        }

        private void OnAReceberButtonClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new AReceber();
            DisplayAlert("A Receber", "A Receber button clicked", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicio();
            Navigation.PopAsync();
        }
    }
}