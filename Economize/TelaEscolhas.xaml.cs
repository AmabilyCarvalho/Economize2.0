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
            Application.Current.MainPage = new ContasAPagarPage();
            //DisplayAlert("Contas a Pagar", "Contas a Pagar button clicked", "OK");
        }

        private void OnDevedoresButtonClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new DevedorPage();
            //DisplayAlert("Devedores", "Devedores button clicked", "OK");
        }

        private void OnAReceberButtonClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new AReceberPage();
            //DisplayAlert("A Receber", "A Receber button clicked", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicio();
            Navigation.PopAsync();
        }
    }
}