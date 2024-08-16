using Microsoft.Maui.Controls;

namespace Economize
{
    public partial class ContaPage : ContentPage
    {
        public ContaPage()
        {
            InitializeComponent();
        }

         private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaEscolhas();
            Navigation.PopAsync();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de adicionar
            // Por exemplo, você pode adicionar o conteúdo do Field5Entry a uma lista
        }

         private void BotaoSalvar(object sender, EventArgs e)
        {
            
        }
    }
}